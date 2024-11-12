using FluentValidation;

namespace EDT.BookLibrary.Application.Features.Books.Upsert
{
    public class BookModelValidator : AbstractValidator<BookModel>
    {
        public BookModelValidator()
        {
            RuleFor(x => x.BookTitle).NotEmpty().MaximumLength(50);
            RuleFor(x => x.AuthorName).NotEmpty().MaximumLength(50);
            RuleFor(x => x.GenreDescription).NotEmpty().MaximumLength(50);
        }
    }
}
