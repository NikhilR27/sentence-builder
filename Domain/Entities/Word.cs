namespace Domain.Entities;

public class Word
{
    public int Id { get; set; }

    public string WordText { get; set; } = null!;

    public int WordTypeId { get; set; }

    public virtual WordType WordType { get; set; } = null!;
}
