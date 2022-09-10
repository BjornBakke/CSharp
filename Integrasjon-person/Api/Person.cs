namespace Integrasjon_person.Api;

public record Person {
    public DateTime Opprettetdato { get; init; }

    public int Fnr { get; init; }

    public string? Adresse { get; init; }
}