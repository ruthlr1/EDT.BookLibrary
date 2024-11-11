using EDT.AuthorLibrary.Application.Features.Authors;
using Microsoft.AspNetCore.Mvc;

namespace EDT.AuthorLibrary.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorController : ControllerBase
    {
        private readonly ILogger<AuthorController> _logger;
        private readonly IAuthorService _authorService;

        public AuthorController(ILogger<AuthorController> logger, IAuthorService AuthorService)
        {
            _logger = logger;
            _authorService = AuthorService;
        }


        [HttpGet("GetAllAuthors")]
        public async Task<IList<AuthorModel>> GetAllAuthors(int nRecords)
        {
            return await _authorService.GetAllAuthors(nRecords);
        }
    }
}
