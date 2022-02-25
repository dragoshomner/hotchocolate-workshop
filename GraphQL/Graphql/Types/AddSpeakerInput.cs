namespace GraphQL.Types
{
    public record AddSpeakerInput(
        string Name, 
        string? Bio,
        string? Website);
}
