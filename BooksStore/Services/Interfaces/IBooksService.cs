using BooksStore.Models;

namespace BooksStore.Services.Interfaces;

public interface IBooksService
{
    Task<List<Book>> GetAllBooksAsync();
}
