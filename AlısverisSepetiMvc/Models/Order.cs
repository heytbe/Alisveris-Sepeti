using AlısverisSepetiMvc.Shared;

namespace AlısverisSepetiMvc.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public ICollection<CardLine> Lines { get; set; } = new List<CardLine>();
        public string Name { get; set; }
        public string Adres { get; set; }
        public DateTime OrderAt { get; set; } = DateTime.Now;
    }
}
