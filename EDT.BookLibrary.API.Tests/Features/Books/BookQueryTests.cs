using EDT.BookLibrary.Application.Features.Books;
using EDT.BookLibrary.Domain.Entities;
using EDT.BookLibrary.Persistence.Repo;
using Microsoft.EntityFrameworkCore;

namespace EDT.BookLibrary.Tests.Features.Books
{
    public class BookQueryTests
    {
        private DbContextOptions<LibraryContext> _dbOptions;


        [Test]
        public async Task GetBooksByGenre()
        {
            using (var context = new LibraryContext(_dbOptions))
            {
                // Arrange
                var genreId = 1;
                var bookService = new BookService(context);

                // Act
                var result = await bookService.GetBooksByGenreId(genreId);

                // Assert
                Assert.That(result.First().BookTitle, Is.EqualTo("Smirf"));
                Assert.That(result.First().AuthorName, Is.EqualTo("Test 1"));
                Assert.That(result.First().GenreDescription, Is.EqualTo("Cartoon"));
            }
        }
        [SetUp]
        public void SetupContext()
        {
            _dbOptions = new DbContextOptionsBuilder<LibraryContext>()
             .UseInMemoryDatabase(databaseName: "TestDatabase", b => b.EnableNullChecks(false))
             .Options; 

            // Insert seed data into the database 
            using (var context = new LibraryContext(_dbOptions))
            {
                context.Authors.Add(new Author() { AuthorId = 1, AuthorName = "Test 1" });
                context.Genres.Add(new Genre() { GenreId = 1, GenreDescription = "Cartoon" });
                context.Books.Add(new Book() { BookTitle = "Smirf", AuthorId = 1, GenreId = 1, });
                context.Genres.Add(new Genre() { GenreId = 2, GenreDescription = "Fruit" });
                context.Books.Add(new Book() { BookTitle = "Apples", AuthorId = 1, GenreId = 2, });
                context.SaveChanges();
            }
        }

        [TearDown]
        public void TearDown()
        {
            using (var context = new LibraryContext(_dbOptions))
            {
                context.Database.EnsureDeleted();
            }
        }
    }
}
