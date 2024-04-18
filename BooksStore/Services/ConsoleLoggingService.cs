using BooksStore.Services.Interfaces;

namespace BooksStore;

public class ConsoleLoggingService : ILoggingService
{
    public void log(string message)
    {
        Console.WriteLine(message);
    }
}
