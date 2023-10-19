using Domain.Dtos;

namespace Application.Words.Responses;

public record GetWordsResponse
{
    public IReadOnlyCollection<WordDto> Words { get; init; } = Array.Empty<WordDto>();
}