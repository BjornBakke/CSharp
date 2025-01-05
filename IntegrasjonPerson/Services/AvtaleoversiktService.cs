using IntegrasjonPerson.Api;
using IntegrasjonPerson.backend;

namespace IntegrasjonPerson.Services;

public class AvtaleoversiktService(AvtaleoversiktEndpoint endpoint)
{
    public Task<List<Produkt>> GetAllByAvtaleId(string productId)
    {
        return AvtaleoversiktEndpoint.GetAllByAgreementId(productId);
    }

    public Task<List<Produkt>> GetAllByKundeId(string customerId)
    {
        return AvtaleoversiktEndpoint.GetAllByCustomerId(customerId: customerId);
    }

    public Task<Produkt> GetById(string id)
    {
        return AvtaleoversiktEndpoint.GetById(id);
    }

    public Task<List<Produkt>> GetAlleAvtaler()
    {
        return AvtaleoversiktEndpoint.GetAlleAvtaler();
    }
}