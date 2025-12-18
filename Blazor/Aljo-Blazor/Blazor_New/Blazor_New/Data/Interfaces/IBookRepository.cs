using Blazor_New.Data.Models;

namespace Blazor_New.Data.Interfaces
{
    public interface IBookRepository
    {
        IList<Book> GetAllBooks();
        void AddBook(Book book);
        void UpdateBook(Book book);
        void DeleteBook(int id);
        Book GetBookById(int id);
    }
}
