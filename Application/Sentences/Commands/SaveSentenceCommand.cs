using System.Windows.Input;
using Application.Sentences.Responses;
using Application.Words.Responses;
using Domain.Entities;
using Infrastructure.Interfaces;
using MediatR;

namespace Application.Sentences.Commands;

public record SaveSentenceCommand : IRequest<SaveSentenceResponse>
{
    public string Sentence { get; init; }
};

public class SaveSentenceCommandHandler : IRequestHandler<SaveSentenceCommand, SaveSentenceResponse>
{
    private readonly ISentenceBuilderRepository _repository;

    public SaveSentenceCommandHandler(ISentenceBuilderRepository repository)
    {
        _repository = repository;
    }

    public async Task<SaveSentenceResponse> Handle(SaveSentenceCommand request, CancellationToken cancellationToken)
    {
        bool result = await _repository.CreateSentenceAsync(new Sentence
        {
            SentenceText = request.Sentence
        });

        return new SaveSentenceResponse { SaveSuccessful = result };
    }
}