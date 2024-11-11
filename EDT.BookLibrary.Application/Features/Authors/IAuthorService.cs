
namespace EDT.AuthorLibrary.Application.Features.Authors
{
    public interface IAuthorService
    {
        Task<IList<AuthorModel>> GetAllAuthors(int nRecords);
    }
}
