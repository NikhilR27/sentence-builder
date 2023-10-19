using Domain.Dtos;

namespace Application.Words.Responses;

public class GetWordsResponse
{
    public List<WordDto> WordDtos { get; set; }
}