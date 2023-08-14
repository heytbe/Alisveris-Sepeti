namespace AlısverisSepetiMvc.Models
{
    public class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string CategoryColor { get; set; }
        public string CategoryImage { get; set; }
        public int CategoryCheck { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
