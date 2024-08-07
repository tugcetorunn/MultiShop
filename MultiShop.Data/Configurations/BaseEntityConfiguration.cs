
namespace MultiShop.Data.Configurations
{
    public class BaseEntityConfiguration : IEntityTypeConfiguration<BaseEntity>
    {
        public void Configure(EntityTypeBuilder<BaseEntity> builder) 
        {
            builder.Property(b => b.IsActive)
                   .HasDefaultValue(true)
                   .IsRequired();

            builder.Property(b => b.CreatedDate)
                   .HasDefaultValue(DateTime.Now);

            builder.Property(b => b.Order)
                   .HasDefaultValue(1);
        }
    }
}
