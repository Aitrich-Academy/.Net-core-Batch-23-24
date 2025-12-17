using Blazor_New.Data.Models;

namespace Blazor_New.Data.Interfaces
{
    public interface IBookService 
    {
        IList<Book> GetAllBooks();
        void  AddBook(Book book);
        void UpdateBook(Book book);
        Book GetBookById(int id);
        void DeleteBook(int id);

    }
}
