

namespace EDT.AuthorLibrary.Application.Features.Authors
{
    public class AuthorModel
    {
        public required int AuthorId { get; set; }
        public required string AuthorName { get; set; }
        public int TotalBooks { get; set; }
    }
}
