using Blazor_Reg_Book.Data.Interfaces;
using Blazor_Reg_Book.Data.Models;

namespace Blazor_Reg_Book.Data.Repository
{
    public class BookRepository:IBookRepository
    {
        private readonly AppDbContext _context;

        public BookRepository(AppDbContext context)
        {
            _context = context;
        }
        public List<Book> GetAllBooks()
        {
            return _context.Books.ToList();
        }

        public void AddBook(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public Book GetBookById(int id)
        {
            var book = _context.Books.FirstOrDefault(x => x.Id == id);
            return book;

        }

        public void  Deletebook(int id)
        {
            var delbook = _context.Books.Find(id);
            if (delbook != null)
            {
                _context.Books.Remove(delbook);
                _context.SaveChanges();
            }
        }

        public void UpdateBook(Book book)
        {
            var existbook=GetBookById(book.Id);
            if (existbook != null)
            {
                existbook.Title = book.Title;
                existbook.Author = book.Author;
                existbook.Description = book.Description;
                existbook.PublishedDate= book.PublishedDate;

              
                _context.SaveChanges();
            }

        }


        public List<Book> GetBookBySearch(string searchTitle)
        {
            var allbooks = _context.Books.Where(b => b.Title.Contains(searchTitle)).ToList();
            return allbooks;
        }
    }
}
