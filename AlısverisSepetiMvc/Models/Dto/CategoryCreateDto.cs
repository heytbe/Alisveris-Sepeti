namespace AlısverisSepetiMvc.Models.Dto
{
    public record CategoryCreateDto
    {
        public string CategoryName { get; set; }
        public string CategoryColor { get; set; }
        public IFormFile CategoryImage { get; set; }
        public int CategoryCheck { get; set; }
    }
}
