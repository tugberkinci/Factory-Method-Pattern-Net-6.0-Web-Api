using FactoryMethodWebApi.Models;

namespace FactoryMethodWebApi.IServices
{
    public interface ICardFactory
    {
        CardModel CardInfo();
    }
}
