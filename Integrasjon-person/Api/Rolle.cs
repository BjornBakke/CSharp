namespace Integrasjon_person.Api;

public record Rolle {
    public DateTime Opprettetdato { get; init; }

    public int Rollenummer { get; init; }

    public string? Type { get; init; }
}