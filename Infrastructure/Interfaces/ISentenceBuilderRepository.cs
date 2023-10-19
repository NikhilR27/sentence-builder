using Domain.Entities;

namespace Infrastructure.Interfaces;

public interface ISentenceBuilderRepository
{
    Task<IReadOnlyCollection<Word>> GetWordsAsync();
    Task<IReadOnlyCollection<SentenceWordMapping>> GetSentenceAsync(int id);
    Task CreateSentenceAsync(SentenceWordMapping sentenceWordMapping);
}