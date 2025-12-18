using Blazor_Reg_Book.Data.Interfaces;
using Blazor_Reg_Book.Data.Models;

namespace Blazor_Reg_Book.Data.Services
{
    public class BookService:IBookServices
    {
        private readonly IBookRepository _repository;

        public BookService(IBookRepository repository)
        {
            _repository = repository;
        }
        public List<Book> GetAllBooks()
        {
            return _repository.GetAllBooks();
        }

        public void AddBook(Book book)
        {
            _repository.AddBook(book);
        }

        public Book GetBookById(int id)
        {
            return _repository.GetBookById(id);
        }

        public void Deletebook(int id)
        {
            _repository.Deletebook(id);
        }

        public void UpdateBook(Book book)
        {
            _repository.UpdateBook(book);
        }

        public List<Book> GetBookBySearch(string searchTitle)
        {
            return _repository.GetBookBySearch(searchTitle);
        }
    }
}
