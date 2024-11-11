using EDT.BookLibrary.Domain.Entities;
using EDT.BookLibrary.Persistence.EntityConfigurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EDT.AuthorLibrary.Persistence.EntityConfigurations
{
    public class AuthorConfiguration : EntityBaseConfiguration<Author>
    {
        public override void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.ToTable(nameof(Author));
            builder.Property(x => x.AuthorName).IsRequired().HasMaxLength(50);

            base.Configure(builder);
        }
    }
}
