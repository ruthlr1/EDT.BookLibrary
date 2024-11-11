
namespace EDT.BookLibrary.Domain.Entities;

public class Genre : EntityBase
{
    public int GenreId { get; set; }
    public required string GenreDescription { get; set; }


    public ICollection<Book> Books { get; set; }

    public enum GenreIndex
    {
        Fiction = 1,
        Action, 
        AutoBiography,
        Suspense
    }
}
