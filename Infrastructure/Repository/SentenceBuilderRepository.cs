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

    public async Task<IReadOnlyCollection<WordType>> GetWordTypesAsync()
    {
        var result = await _context
            .Set<WordType>()
            .Include(t => t.Words)
            .ToListAsync();
        return result;
    }

    public async Task<IReadOnlyCollection<string>> GetSentencesAsync()
    {
        var result = await _context
            .Set<Sentence>()
            .Select(s => s.SentenceText)
            .ToListAsync();
        return result;
    }

    public async Task<bool> CreateSentenceAsync(Sentence sentence)
    {
        try
        {
            await _context.Set<Sentence>().AddAsync(sentence);
            int rowsAffected = await _context.SaveChangesAsync();
            return rowsAffected > 0;
        }
        catch (DbUpdateException)
        {
            return false;
        }
    }
}