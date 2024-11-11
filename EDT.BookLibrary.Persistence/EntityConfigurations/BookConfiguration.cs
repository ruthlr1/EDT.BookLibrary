using EDT.BookLibrary.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EDT.BookLibrary.Persistence.EntityConfigurations
{
    public class BookConfiguration : EntityBaseConfiguration<Book>
    {
        public override void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable(nameof(Book));
            builder.Property(x => x.BookTitle).IsRequired().HasMaxLength(100);

            base.Configure(builder);
        }
    }
}
