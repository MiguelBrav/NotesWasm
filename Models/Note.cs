﻿namespace NotesWasm.Models;

public class Note
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;    
    public string Category {  get; set; } = string.Empty;
    public bool IsFavorite { get; set; } = false;
}
