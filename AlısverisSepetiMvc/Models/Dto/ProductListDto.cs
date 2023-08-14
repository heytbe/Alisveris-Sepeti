namespace AlısverisSepetiMvc.Models.Dto
{
    public record ProductListDto
    {
        public int Id { get; set; }
        public string ProductName { get; init; }
        public string ProductImage { get; init; }
        public decimal ProductPrice { get; init; }
        public int ProductCheck { get; init; }
        public int CategoryId { get; init; }
    }
}
