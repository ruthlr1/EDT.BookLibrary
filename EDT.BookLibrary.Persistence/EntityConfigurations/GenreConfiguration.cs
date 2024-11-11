using EDT.BookLibrary.Domain.Entities;
using EDT.BookLibrary.Persistence.EntityConfigurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EDT.GenreLibrary.Persistence.EntityConfigurations
{
    public class GenreConfiguration : EntityBaseConfiguration<Genre>
    {
        public override void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.ToTable(nameof(Genre));
            builder.Property(x => x.GenreDescription).IsRequired().HasMaxLength(50);

            base.Configure(builder);
        }
    }
}
