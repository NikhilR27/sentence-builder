using Application.Words.Responses;
using MediatR;

namespace Application.Words.Queries;

public record GetWordsQuery : IRequest<GetWordsResponse>;

public class GetWordsQueryHandler : IRequestHandler<GetWordsQuery, GetWordsResponse>
{
    public Task<GetWordsResponse> Handle(GetWordsQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}