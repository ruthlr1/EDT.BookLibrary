using EDT.GenreLibrary.Application.Features.Genres;
using Microsoft.AspNetCore.Mvc;

namespace EDT.GenreLibrary.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GenreController : ControllerBase
    {
        private readonly ILogger<GenreController> _logger;
        private readonly IGenreService _authorService;

        public GenreController(ILogger<GenreController> logger, IGenreService GenreService)
        {
            _logger = logger;
            _authorService = GenreService;
        }


        [HttpGet("GetAllGenres")]
        public async Task<IList<GenreModel>> GetAllGenres(int nRecords)
        {
            return await _authorService.GetAllGenres(nRecords);
        }
    }
}
