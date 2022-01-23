using FactoryMethodWebApi.Cards;
using FactoryMethodWebApi.IServices;

namespace FactoryMethodWebApi.Services
{
    public class FactoryService : IFactoryService
    {
        public ICardFactory Get(string ProviderName)
        {
            if(String.IsNullOrEmpty(ProviderName))
                return null;
            else if (String.Equals(ProviderName, "MasterCard"))
                return new MasterCard();
            else if(String.Equals(ProviderName,"VisaCard"))
                return new VisaCard();
            else
                return null;
        }
    }
}
