using Microsoft.AspNetCore.Http;

namespace AlısverisSepetiMvc.Models.Dto
{
    public record ProductCreateDto
    {
        public string ProductName { get; init; }
        public IFormFile ProductImage { get; set; }
        public decimal ProductPrice { get; init; }
        public int ProductCheck { get; set; }
        public int CategoryId { get; set; }
    }
}
