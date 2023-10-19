using Domain.Entities;
using Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;

public class SentenceBuilderRepository : ISentenceBuilderRepository
{
    private readonly DbContext _context;

    public SentenceBuilderRepository(DbContext context)
    {
        _context = context;
    }

    public async Task<IReadOnlyCollection<Word>> GetWordsAsync()
    {
        var result = await _context
            .Set<Word>()
            .Include(t => t.WordType)
            .ToListAsync();
        return result;
    }

    public async Task<IReadOnlyCollection<SentenceWordMapping>> GetSentenceAsync(int id)
    {
        var result = await _context
            .Set<SentenceWordMapping>()
            .Where(x => x.SentenceId == id)
            .ToListAsync();
        return result;
    }

    public async Task CreateSentenceAsync(SentenceWordMapping sentenceWordMapping)
    {
        await _context.Set<SentenceWordMapping>().AddAsync(sentenceWordMapping);
        await _context.SaveChangesAsync();
    }
}