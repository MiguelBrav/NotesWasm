namespace NotesWasm.Models;

public class Category
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public bool IsFavorite { get; set; } = false;
}
