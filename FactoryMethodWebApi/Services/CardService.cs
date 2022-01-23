using FactoryMethodWebApi.IServices;
using FactoryMethodWebApi.Models;

namespace FactoryMethodWebApi.Services
{
    public class CardService : ICardService
    {

        private readonly IFactoryService _factoryService;

        public CardService(IFactoryService factoryService)
        {
            _factoryService = factoryService;
        }

        public CardModel GetCardInfo(string cardName)
        {
            return (CardModel)_factoryService.Get(cardName);
        }
    }
}
