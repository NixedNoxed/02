using LibraryApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApp.Controllers
{
    public class BooksController : Controller
    {
        private readonly BooksDbContext _context;

        public BooksController(BooksDbContext context)
        {
            _context = context;
        }

        // Действие за извличане на списък с книги
        public IActionResult Index()
        {
            var books = _context.Books.ToList();
            return View(books);
        }

        // Действие за добавяне на нова книга
        [HttpPost]
        public IActionResult Add(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
