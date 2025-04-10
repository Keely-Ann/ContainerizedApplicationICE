using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RetailMVC.Models;

namespace RetailMVC.Data.Config
{
    public class ProductsConfiguration : IEntityTypeConfiguration<Products>
    {
        public void Configure(EntityTypeBuilder<Products> builder)
        {
            builder.HasKey(a => a.ID);

            builder.Property(a => a.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(a => a.Price)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasData(
                new Products
                {
                    ID = 1,
                    Name = "Wii Sport Resort",
                    Price = 1300
                },
                new Products
                {
                    ID = 2,
                    Name = "Super Mario Party",
                    Price = 1200
                },
                new Products
                {
                    ID = 3,
                    Name = "Astro Bot",
                    Price = 1200
                }
            );
        }
    }
}
