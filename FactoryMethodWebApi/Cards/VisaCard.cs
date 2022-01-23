using FactoryMethodWebApi.IServices;
using FactoryMethodWebApi.Models;

namespace FactoryMethodWebApi.Cards
{
    public class VisaCard : ICardFactory
    {
        public CardModel CardInfo()
        {
            return new CardModel { Id = 1, Name = "Visa Card" };
        }
    }
}
