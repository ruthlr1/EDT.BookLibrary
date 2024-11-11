using EDT.BookLibrary.Application.Features.Books;
using Microsoft.AspNetCore.Mvc;

namespace EDT.BookLibrary.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        private readonly ILogger<BookController> _logger;
        private readonly IBookService _bookService;

        public BookController(ILogger<BookController> logger, IBookService BookService)
        {
            _logger = logger;
            _bookService = BookService;
        }


        [HttpGet("GetBookListByAuthor")]
        public async Task<IList<BookModel>> GetBookListByAuthor(int authorId)
        {
            return await _bookService.GetBooksByAuthorId(authorId);
        }


        [HttpGet("GetBookListByGenre")]
        public async Task<IList<BookModel>> GetBookListByGenre(int genreId)
        {
            return await _bookService.GetBooksByGenreId(genreId);
        }
    }
}
