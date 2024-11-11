
using EDT.BookLibrary.Domain.Entities;
using EDT.BookLibrary.Persistence.Repo;
using EDT.GenreLibrary.Application.Features.Genres;
using Microsoft.EntityFrameworkCore;

namespace EDT.BookLibrary.Application.Features.Books
{
    public class BookService : IBookService
    {
        private readonly LibraryContext _context;
        public BookService(LibraryContext context)
        {
            _context = context;
        }
        public async Task<IList<BookModel>> GetBooksByAuthorId(int authorId)
        {
            return await _context.Books.AsNoTracking().Where(x => x.AuthorId == authorId)
                                                      .OrderBy(x => x.BookTitle)
                                                      .Select(x => new BookModel() { BookTitle = x.BookTitle, AuthorName = x.Author.AuthorName, GenreDescription = x.Genre.GenreDescription })
                                                      .ToListAsync();
        }

        public async Task<IList<BookModel>> GetBooksByGenreId(int genreId)
        {
            return await _context.Books.AsNoTracking().Where(x => x.GenreId == genreId)
                                                      .OrderBy(x => x.BookTitle)
                                                      .Select(x => new BookModel() {  BookTitle = x.BookTitle, AuthorName = x.Author.AuthorName, GenreDescription = x.Genre.GenreDescription })
                                                      .ToListAsync();
        }
    }
}
