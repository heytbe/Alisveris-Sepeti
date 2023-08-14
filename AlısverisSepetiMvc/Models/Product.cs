namespace AlısverisSepetiMvc.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductImage { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductCheck { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
