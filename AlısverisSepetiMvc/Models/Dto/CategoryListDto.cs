namespace AlısverisSepetiMvc.Models.Dto
{
    public record CategoryListDto
    {
        public int Id { get; init; }
        public string CategoryName { get; init; }
        public string CategoryColor { get; init; }
        public string CategoryImage { get; init; }
        public int CategoryCheck { get; init; }
    }
}
