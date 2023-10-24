using Domain.Dtos;

namespace Application.Words.Responses;

public record GetWordTypesResponse
{
    public IReadOnlyCollection<WordTypeDto> WordTypes { get; init; } = Array.Empty<WordTypeDto>();
}