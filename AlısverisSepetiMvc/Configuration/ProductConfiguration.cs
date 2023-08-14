using AlısverisSepetiMvc.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AlısverisSepetiMvc.Configuration
{
    public class ProductConfiguration : IBaseConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
           builder.HasOne(x => x.Category).WithMany(x => x.Products).HasForeignKey(x => x.CategoryId);
        }
    }
}
