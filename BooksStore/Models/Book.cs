﻿namespace BooksStore.Models;

public class Book
{
    public string? Id { get; set;}
    public string? Title { get; set;}
    public string? AuthorName { get; set; }
    public string? Description { get; set;} = string.Empty;
    public DateTime PublishingDate { get; set; }
    public decimal Price { get; set; }

    
}