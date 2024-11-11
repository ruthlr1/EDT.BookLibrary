
using EDT.BookLibrary.Persistence.Repo;
using Microsoft.EntityFrameworkCore;

namespace EDT.AuthorLibrary.Application.Features.Authors
{
    public class AuthorService : IAuthorService
    {
        private readonly LibraryContext _context;
        public AuthorService(LibraryContext context)
        {
            _context = context;
        }

        public async Task<IList<AuthorModel>> GetAllAuthors(int nRecords)
        {
            return await _context.Authors.AsNoTracking().OrderBy(x => x.AuthorName)
                                                        .Take(nRecords)
                                                        .Select(x => new AuthorModel() { AuthorId = x.AuthorId, AuthorName = x.AuthorName, TotalBooks = x.Books.Count })
                                                        .ToListAsync();
        }

    }
}
