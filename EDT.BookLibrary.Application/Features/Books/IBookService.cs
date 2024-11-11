
namespace EDT.BookLibrary.Application.Features.Books
{
    public interface IBookService
    {
        Task<IList<BookModel>> GetBooksByAuthorId(int authorId);
        Task<IList<BookModel>> GetBooksByGenreId(int genreId);
    }
}
