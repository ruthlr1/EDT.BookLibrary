

namespace EDT.GenreLibrary.Application.Features.Genres
{
    public interface IGenreService
    {
        Task<IList<GenreModel>> GetAllGenres(int nRecords);
    }
}
