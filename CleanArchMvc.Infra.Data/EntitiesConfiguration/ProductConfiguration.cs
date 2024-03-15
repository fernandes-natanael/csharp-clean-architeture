using CleanArchMvc.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchMvc.Infra.Data.EntitiesConfiguration;
public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(prod => prod.Id); // Define Primary Key
        builder.Property(prod => prod.Name).HasMaxLength(180).IsRequired();
        builder.Property(prod => prod.Description).HasMaxLength(200).IsRequired();
        builder.Property(prod => prod.Price).HasPrecision(12, 2);
        builder.HasOne(p => p.Category).WithMany(e => e.Products).HasForeignKey(e => e.CategoryId);
    }
}
