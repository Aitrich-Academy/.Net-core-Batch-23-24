using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly AppDbContext _context;

        public BooksController(AppDbContext context)
        {
            _context = context;
        }

        // Get all books
        [HttpGet]
        public ActionResult GetBooks()
        {
            var books = _context.Books.ToList();
            return Ok(books); // Return all books
        }

        // Get a book by ID
        [HttpGet("{id}")]
        public ActionResult<Book> GetBook(int id)
        {
            var book = _context.Books.Find(id);
            if (book == null)
            {
                return NotFound(); // If book not found, return 404
            }
            return Ok(book); // Return the found book
        }

        // Create a new book
        [HttpPost]
        public ActionResult PostBook(Book book)
        {
            _context.Books.Add(book); // Add the new book
            _context.SaveChanges(); // Save changes to the database
            return Ok(book); // Return the created book
        }

        // Update a book
        [HttpPut("{id}")]
        public ActionResult PutBook(int id, Book book)
        {
            if (id != book.Id)
            {
                return BadRequest(); // Return 400 if IDs don't match
            }

            _context.Books.Update(book); // Update the book
            _context.SaveChanges(); // Save changes to the database
            return Ok(book); // Return a 200 OK
        }

        // Delete a book
        [HttpDelete("{id}")]
        public ActionResult DeleteBook(int id)
        {
            var book = _context.Books.Find(id);
            if (book == null)
            {
                return NotFound(); // If book not found, return 404
            }

            _context.Books.Remove(book); // Remove the book
            _context.SaveChanges(); // Save changes to the database
            return Ok(book); // Return a 200 OK on successful deletion
        }
    }
}
