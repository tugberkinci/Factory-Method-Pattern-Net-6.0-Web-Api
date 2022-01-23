using FactoryMethodWebApi.IServices;
using FactoryMethodWebApi.Models;

namespace FactoryMethodWebApi.Cards
{
    public class MasterCard : ICardFactory
    {
        public CardModel CardInfo()
        {
            return new CardModel { Id = 1, Name = "Master Card" };
        }


    }
}
