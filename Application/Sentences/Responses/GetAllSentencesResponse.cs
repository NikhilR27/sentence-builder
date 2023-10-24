namespace Application.Sentences.Responses;

public class GetAllSentencesResponse
{
    public IReadOnlyCollection<string> Sentences { get; init; } = Array.Empty<string>();
}