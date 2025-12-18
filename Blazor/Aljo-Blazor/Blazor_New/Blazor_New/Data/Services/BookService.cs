using Blazor_New.Data.Interfaces;
using Blazor_New.Data.Models;

namespace Blazor_New.Data.Services
{
    public class BookService:IBookService
    {
        private readonly IBookRepository _bookRepository;
        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public IList<Book> GetAllBooks()
        {
            return _bookRepository.GetAllBooks();
        }
        public void AddBook(Book book)
        {
            _bookRepository.AddBook(book);
        }
        public void UpdateBook(Book book)
        {
            _bookRepository.UpdateBook(book);
        }
        public Book GetBookById(int id)
        {
            return _bookRepository.GetBookById(id);
        }
        public void DeleteBook(int id)
        {
            _bookRepository.DeleteBook(id);
        }
    }
}
