using EDT.BookLibrary.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Linq;

namespace EDT.BookLibrary.Persistence.Repo;

public class LibraryContext : DbContext
{
    public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        SeedAuthos(modelBuilder);
        SeedGenres(modelBuilder);
        SeedBooks(modelBuilder);
    }
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Genre> Genres { get; set; }

    private void SeedGenres(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Genre>().HasData(
                Enum.GetValues(typeof(Genre.GenreIndex))
                .Cast<Genre.GenreIndex>()
                .Select(e => new Genre()
                {
                    GenreId = (int)e,
                    GenreDescription = e.ToString(),
                })
            );

    }

    private void SeedAuthos(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Author>().HasData(new List<Author>(){
            new Author() { AuthorId = 1, AuthorName = "J. K. Rowling" },
            new Author() { AuthorId = 2, AuthorName = "Sidney Sheldon" },
            new Author() { AuthorId = 3, AuthorName = "Dan Carter" },
        });

    }

    private void SeedBooks(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>().HasData(new List<Book>(){
            new Book() { BookId = 1, BookTitle = "Harry Potter 1", AuthorId = 1, GenreId = (int)Genre.GenreIndex.Fiction  },
            new Book() { BookId = 2, BookTitle = "Harry Potter 2", AuthorId = 1, GenreId = (int)Genre.GenreIndex.Fiction  },
            new Book() { BookId = 3, BookTitle = "The Naked Face" , AuthorId  = 2 , GenreId = (int)Genre.GenreIndex.Suspense},
            new Book() { BookId = 4, BookTitle = "Rugby" , AuthorId  = 3 , GenreId = (int)Genre.GenreIndex.AutoBiography},
        });

    }
}
