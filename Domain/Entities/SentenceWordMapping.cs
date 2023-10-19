namespace Domain.Entities;

public partial class SentenceWordMapping
{
    public int SentenceId { get; set; }

    public int WordId { get; set; }

    public int DisplayOrder { get; set; }

    public virtual Sentence Sentence { get; set; } = null!;

    public virtual Word Word { get; set; } = null!;
}
