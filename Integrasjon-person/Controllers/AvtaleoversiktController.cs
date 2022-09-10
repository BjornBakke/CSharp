using Integrasjon_person.Api;
using Integrasjon_person.Services;
using Microsoft.AspNetCore.Mvc;

namespace Integrasjon_person.Controllers;

[ApiController]
[Route("v1/avtaleoversikt")]
public class ProductOrderController : ControllerBase {
    [HttpGet]
    public async Task<List<Produkt>> GetAvtaler(AvtaleoversiktService avtaleoversiktService,
        [FromQuery] AvtaleQuery query) {
        List<Produkt> orders;

        if (!string.IsNullOrEmpty(query.AvtaleId)) 
            orders = await avtaleoversiktService.GetAllByAvtaleId(query.AvtaleId);

        else if (!string.IsNullOrEmpty(query.KundeId))
            orders = await avtaleoversiktService.GetAllByKundeId(query.KundeId);

        else orders = await avtaleoversiktService.GetAlleAvtaler();
        return orders;
    }

    [HttpGet("{id}")]
    public async Task<Produkt> GetOrderById(AvtaleoversiktService avtaleoversiktService, string id) {
        return await avtaleoversiktService.GetById(id);
    }
}

public record AvtaleQuery(string? AvtaleId, string? KundeId);