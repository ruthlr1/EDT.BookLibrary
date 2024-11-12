using EDT.BookLibrary.Application.Features.Books;
using EDT.BookLibrary.Application.Features.Books.Upsert;
using FluentValidation;

namespace EDT.BookLibrary.Tests.Features.Books
{
    public class BookValidatorTests
    {
        [Test]
        public void ValidateBookTitleIsEmpty()
        {
            // Arrange 
            BookModel model = new BookModel() { BookTitle = "", AuthorName = "Test", GenreDescription = "Test" };
            var validator = new BookModelValidator();

            // Act and Assert
            Assert.Throws<ValidationException>(() => validator.ValidateAndThrow(model));
        }
        [Test]
        public void ValidateBookTitleIsNotEmpty()
        {
            // Arrange 
            BookModel model = new BookModel() { BookTitle = "Test", AuthorName = "Test", GenreDescription = "Test" };
            var validator = new BookModelValidator();

            // Act and Assert
            Assert.DoesNotThrow(() => validator.ValidateAndThrow(model));
        }
    }
}
