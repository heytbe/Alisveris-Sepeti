using AlısverisSepetiMvc.Models;
using System.Security.Cryptography;

namespace AlısverisSepetiMvc.Shared
{
    public class Card
    {
        public List<CardLine> CardLines { get; set; }

        public Card()
        {
            CardLines = new List<CardLine>();
        }

        public virtual void AddItem(Product product,int quantity)
        {
            CardLine? line = CardLines.Where(x => x.Product.Id == product.Id).FirstOrDefault();
            if(line is null)
            {
                CardLines.Add(new CardLine
                {
                    Product = product,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public virtual void RemoveItem(Product product)
        {
            CardLines.RemoveAll(x => x.Product.Id == product.Id);
        }

        public virtual void Clear()
        {
            CardLines.Clear();
        }
    }
}
