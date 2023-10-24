using Application.Words.Responses;
using AutoMapper;
using Domain.Dtos;
using Infrastructure.Interfaces;
using MediatR;

namespace Application.Words.Queries;

public record GetWordTypesQuery : IRequest<GetWordTypesResponse>;

public class GetWordTypesQueryHandler : IRequestHandler<GetWordTypesQuery, GetWordTypesResponse>
{
    private readonly ISentenceBuilderRepository _repository;
    private readonly IMapper _mapper;

    public GetWordTypesQueryHandler(ISentenceBuilderRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<GetWordTypesResponse> Handle(GetWordTypesQuery request, CancellationToken cancellationToken)
    {
        var result = _mapper.Map<IReadOnlyCollection<WordTypeDto>>(await _repository.GetWordTypesAsync());
        return new GetWordTypesResponse
        {
            WordTypes = result
        };
    }
}