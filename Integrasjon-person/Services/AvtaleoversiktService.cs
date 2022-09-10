using Integrasjon_person.Api;
using Integrasjon_person.backend;

namespace Integrasjon_person.Services;

public class AvtaleoversiktService {
    private readonly AvtaleoversiktEndpoint _endpoint;

    public AvtaleoversiktService(AvtaleoversiktEndpoint endpoint) {
        _endpoint = endpoint;
    }

    public Task<List<Produkt>> GetAllByAvtaleId(string productId) {
        return _endpoint.GetAllByAgreementId(productId);
    }

    public Task<List<Produkt>> GetAllByKundeId(string customerId) {
        return _endpoint.GetAllByCustomerId(customerId);
    }

    public Task<Produkt> GetById(string id) {
        return _endpoint.GetById(id);
    }

    public Task<List<Produkt>> GetAlleAvtaler() {
        return _endpoint.GetAlleAvtaler();
    }
}