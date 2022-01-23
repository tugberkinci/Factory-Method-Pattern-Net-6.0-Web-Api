namespace FactoryMethodWebApi.IServices
{
    public interface IFactoryService
    {
        ICardFactory Get(string ProviderName);
    }
}
