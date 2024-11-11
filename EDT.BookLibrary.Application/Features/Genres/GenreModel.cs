

namespace EDT.GenreLibrary.Application.Features.Genres
{
    public class GenreModel
    {
        public required int GenreId { get; set; }
        public required string GenreDescription { get; set; }
        public int TotalBooks { get; set; }
    }
}
