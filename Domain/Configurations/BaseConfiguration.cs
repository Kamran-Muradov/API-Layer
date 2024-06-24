using Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Configurations
{
    public class BaseConfiguration<T> : IEntityTypeConfiguration<T> where T : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(m => m.CreatedDate)
                .HasDefaultValue(DateTime.Now);

            builder.Property(m => m.SoftDeleted)
                .HasDefaultValue(false);
        }
    }
}
