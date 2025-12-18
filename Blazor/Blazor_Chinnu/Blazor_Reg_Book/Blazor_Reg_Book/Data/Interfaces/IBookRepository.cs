using Blazor_Reg_Book.Data.Models;

namespace Blazor_Reg_Book.Data.Interfaces
{
    public interface IBookRepository
    {
        List<Book> GetAllBooks();
        void AddBook(Book book);

       Book GetBookById(int id);
        void Deletebook(int id);
        void UpdateBook(Book book);

        List<Book> GetBookBySearch(string searchTitle);
    }
}
