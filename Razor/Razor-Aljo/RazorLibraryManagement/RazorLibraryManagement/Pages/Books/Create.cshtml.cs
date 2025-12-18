using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorLibraryManagement.Models;

namespace RazorLibraryManagement.Pages.Books
{
    public class CreateModel : PageModel
    {
        private readonly LibraryDbContext _context;

        public CreateModel(LibraryDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public BookModel Book { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.BookTable.Add(Book);
            _context.SaveChanges();

            return RedirectToPage("Index");
        }
    }
}
