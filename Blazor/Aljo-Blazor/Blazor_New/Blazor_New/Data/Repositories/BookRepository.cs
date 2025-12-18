using Blazor_New.Data.Interfaces;
using Blazor_New.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Blazor_New.Data.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly AppDbContext _appDbContext;
        public BookRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IList<Book> GetAllBooks()
        {
            var book = _appDbContext.books.ToList();
            return book;
        }
        public void AddBook(Book book)
        {
            _appDbContext.books.Add(book);
            _appDbContext.SaveChanges();
        }
        public Book GetBookById(int id)
        {
            var book = _appDbContext.books.FirstOrDefault(b => b.BookId == id);
            return book;
        }
        public void DeleteBook(int id)
        {
            var book = _appDbContext.books.Find(id);

            if (id != null)
            {
                _appDbContext.books.Remove(book);
                _appDbContext.SaveChanges();
            }
        }
        public void UpdateBook(Book book)
        {
            var bookid = GetBookById(book.BookId);
            if (bookid != null)
            {
                _appDbContext.books.Update(book);
                _appDbContext.SaveChanges();
            }
        }
    }
}
