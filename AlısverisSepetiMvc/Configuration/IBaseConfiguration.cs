using Microsoft.EntityFrameworkCore;

namespace AlısverisSepetiMvc.Configuration
{
    public interface IBaseConfiguration<T> : IEntityTypeConfiguration<T> where T : class
    {
    }
}
