using EDT.BookLibrary.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace EDT.BookLibrary.Persistence.EntityConfigurations
{
    public abstract class EntityBaseConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : EntityBase
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.Property(t => t.CreatedDateTime).HasDefaultValueSql("GETDATE()");
        }
    }
}
