// using Application.Words.Responses;
// using AutoMapper;
// using Domain.Dtos;
// using Infrastructure.Interfaces;
// using MediatR;
//
// namespace Application.Words.Queries;
//
// public record GetWordsQuery : IRequest<GetWordsResponse>;
//
// public class GetWordsQueryHandler : IRequestHandler<GetWordsQuery, GetWordsResponse>
// {
//     private readonly ISentenceBuilderRepository _repository;
//     private readonly IMapper _mapper;
//
//     public GetWordsQueryHandler(ISentenceBuilderRepository repository, IMapper mapper)
//     {
//         _repository = repository;
//         _mapper = mapper;
//     }
//
//     public async Task<GetWordsResponse> Handle(GetWordsQuery request, CancellationToken cancellationToken)
//     {
//         var result = _mapper.Map<IReadOnlyCollection<WordDto>>(await _repository.GetWordsAsync());
//         return new GetWordsResponse
//         {
//             Words = result
//         };
//     }
// }