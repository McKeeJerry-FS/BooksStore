using BooksStore.Models;
using BooksStore.Services.Interfaces;

namespace BooksStore;

public class LocalBookService : IBooksService
{
    static List<Book> _allBooks = new List<Book>{
        new Book{
            Title = "Blazor WebAssembly Guide",
            AuthorName = "John Smith",
            PublishingDate = new DateTime(2022, 07, 17)
        },
        new Book{
            Title = "Mastering Blazor WebAssembly",
            AuthorName = "John Smith",
            PublishingDate = new DateTime(2023, 07, 29)
        },
        new Book{
            Title = "Learning Blazor from A to Z",
            AuthorName = "John Smith",
            PublishingDate = new DateTime(2018, 04, 07)
        },

    };


    public Task<List<Book>> GetAllBooksAsync()
    {
        return Task.FromResult(_allBooks);
    }
}
