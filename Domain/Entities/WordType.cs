namespace Domain.Entities;

public partial class WordType
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public virtual ICollection<Word> Words { get; set; } = new List<Word>();
}
