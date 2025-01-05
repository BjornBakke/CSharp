using IntegrasjonPerson.Api;

namespace IntegrasjonPerson.backend;

public class AvtaleoversiktEndpoint {
    public static Task<List<Produkt>> GetAllByAgreementId(string productId) {
        throw new NotImplementedException("GetAllByProductId");
    }

    public static Task<List<Produkt>> GetAllByCustomerId(string customerId) {
        throw new NotImplementedException("GetAllByCustomerId");
    }

    public static Task<List<Produkt>> GetAlleAvtaler() {
        throw new NotImplementedException("GetAll");
    }

    public static Task<Produkt> GetById(string id) {
        throw new NotImplementedException("GetById");
    }
}