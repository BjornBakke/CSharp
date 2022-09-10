using Integrasjon_person.Api;
using Microsoft.AspNetCore.Mvc;

namespace Integrasjon_person.Controllers;

[ApiController]
[Route("[controller]")]
public class RolleController : ControllerBase {
    private static readonly string[] Roller = new[] { "Forsikret", "Betaler" };


    [HttpGet(Name = "GetRolle")]
    public IEnumerable<Rolle> Get() {
        return Enumerable.Range(1, 5).Select(index => new Rolle {
                Opprettetdato = DateTime.Now.AddDays(index),
                Rollenummer = Random.Shared.Next(-20, 55),
                Type = Roller[Random.Shared.Next(Roller.Length)]
            })
            .ToArray();
    }
}