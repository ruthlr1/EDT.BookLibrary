
namespace EDT.BookLibrary.Domain.Entities;

public class Author : EntityBase
{
    public int AuthorId { get; set; }
    public required string AuthorName { get; set; } 

    public ICollection<Book> Books { get; set; }
}
