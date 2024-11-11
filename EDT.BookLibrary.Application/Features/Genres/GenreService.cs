using EDT.BookLibrary.Persistence.Repo;
using Microsoft.EntityFrameworkCore;

namespace EDT.GenreLibrary.Application.Features.Genres
{
    public class GenreService : IGenreService
    {
        private readonly LibraryContext _context;
        public GenreService(LibraryContext context)
        {
            _context = context;
        }

        public async Task<IList<GenreModel>> GetAllGenres(int nRecords)
        {
            return await _context.Genres.AsNoTracking().OrderBy(x => x.GenreDescription)
                                                       .Take(nRecords)
                                                       .Select(x => new GenreModel() { GenreId = x.GenreId, GenreDescription = x.GenreDescription, TotalBooks = x.Books.Count })
                                                       .ToListAsync();
        }

    }
}
