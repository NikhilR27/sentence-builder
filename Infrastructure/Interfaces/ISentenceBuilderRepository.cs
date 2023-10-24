using Domain.Entities;

namespace Infrastructure.Interfaces;

public interface ISentenceBuilderRepository
{
    // Task<IReadOnlyCollection<Word>> GetWordsAsync();
    Task<IReadOnlyCollection<WordType>> GetWordTypesAsync();
    Task<IReadOnlyCollection<string>> GetSentencesAsync();
    Task<bool> CreateSentenceAsync(Sentence sentence);
}