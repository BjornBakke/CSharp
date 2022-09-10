using Integrasjon_person.Api;

namespace Integrasjon_person.backend;

public class AvtaleoversiktEndpoint {
    public Task<List<Produkt>> GetAllByAgreementId(string productId) {
        throw new NotImplementedException("GetAllByProductId");
    }

    public Task<List<Produkt>> GetAllByCustomerId(string customerId) {
        throw new NotImplementedException("GetAllByCustomerId");
    }

    public Task<List<Produkt>> GetAlleAvtaler() {
        throw new NotImplementedException("GetAll");
    }

    public Task<Produkt> GetById(string id) {
        throw new NotImplementedException("GetById");
    }
}