
namespace EDT.BookLibrary.Domain.Entities;

public class Book : EntityBase
{
    public int BookId { get; set; }
    public required string BookTitle { get; set; }


    public required int AuthorId { get; set; }
    public Author Author { get; set; } = null!;

    public required int GenreId { get; set; }
    public Genre Genre { get; set; } = null!;
}
