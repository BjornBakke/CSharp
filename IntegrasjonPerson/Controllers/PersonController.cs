using IntegrasjonPerson.Api;
using Microsoft.AspNetCore.Mvc;

namespace IntegrasjonPerson.Controllers;

[ApiController]
[Route("[controller]")]
public class PersonController : ControllerBase {
    [HttpGet(Name = "Person")]
    public IEnumerable<Person> Get() {
        return Enumerable.Range(1, 5).Select(index => new Person {
                Opprettetdato = DateTime.Now.AddDays(index),
                Fnr = Random.Shared.Next(-1110550000, 1110999999),
                Adresse = "Oslo S, 0598, Norge"
            })
            .ToArray();
    }
}