using Application.Sentences.Responses;
using Application.Words.Responses;
using AutoMapper;
using Domain.Dtos;
using Infrastructure.Interfaces;
using MediatR;

namespace Application.Words.Queries;

public record GetAllSentencesQuery : IRequest<GetAllSentencesResponse>;

public class GetWordsQueryHandler : IRequestHandler<GetAllSentencesQuery, GetAllSentencesResponse>
{
    private readonly ISentenceBuilderRepository _repository;

    public GetWordsQueryHandler(ISentenceBuilderRepository repository, IMapper mapper)
    {
        _repository = repository;
    }

    public async Task<GetAllSentencesResponse> Handle(GetAllSentencesQuery request, CancellationToken cancellationToken)
    {
        var result = new GetAllSentencesResponse
        {
            Sentences = await _repository.GetSentencesAsync()
        };
        return result;
    }
}