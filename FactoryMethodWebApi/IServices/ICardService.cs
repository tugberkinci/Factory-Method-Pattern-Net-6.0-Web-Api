using FactoryMethodWebApi.Models;

namespace FactoryMethodWebApi.IServices
{
    public interface ICardService
    {
        CardModel GetCardInfo(string cardName);
    }
}
