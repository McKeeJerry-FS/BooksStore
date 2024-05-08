using BooksStore.Models;

namespace BooksStore.Services.Interfaces;

public interface IBooksService
{
    Task<List<Book>> GetAllBooksAsync();
    Task<Book?> GetBookByIdAsync(string? id);
}
