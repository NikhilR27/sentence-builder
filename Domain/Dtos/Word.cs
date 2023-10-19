namespace Domain.Dtos;

public class WordDto
{
    public int Id { get; set; }
    public string WordText { get; set; }
    public WordTypeDto WordTypeDto { get; set; }
}