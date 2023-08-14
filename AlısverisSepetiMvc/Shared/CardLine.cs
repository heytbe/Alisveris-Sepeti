using AlısverisSepetiMvc.Models;

namespace AlısverisSepetiMvc.Shared
{
    public class CardLine
    {
        public int CardLineId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
