using AlısverisSepetiMvc.Models;
using System.Text.Json.Serialization;

namespace AlısverisSepetiMvc.Shared
{
    public class SessionCard : Card
    {
        [JsonIgnore]
        public ISession Session { get; set; }
        public static Card GetCard(IServiceProvider services)
        {
            ISession? session = services.GetRequiredService<IHttpContextAccessor>().HttpContext?.Session;
            SessionCard card = session?.GetJson<SessionCard>("card") ?? new SessionCard();
            card.Session = session;
            return card;
        }

        public override void AddItem(Product product, int quantity)
        {
            base.AddItem(product, quantity);
            Session?.SetJson<SessionCard>("card", this);
        }

        public override void RemoveItem(Product product)
        {
            base.RemoveItem(product);
            Session?.SetJson<SessionCard>("card",this);
        }

        public override void Clear()
        {
            base.Clear();
            Session?.Remove("card");
        }
    }
}
