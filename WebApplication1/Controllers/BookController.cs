using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            var books = new List<BookModel>();

            books.Add(new BookModel { BookId = 1, Name = "Book Name 1", Author = "Book Author 1" });
            books.Add(new BookModel { BookId = 2, Name = "Book Name 2", Author = "Book Author 2" });
            books.Add(new BookModel { BookId = 3, Name = "Book Name 3", Author = "Book Author 3" });
            books.Add(new BookModel { BookId = 4, Name = "Book Name 4", Author = "Book Author 4" });
            books.Add(new BookModel { BookId = 5, Name = "Book Name 5", Author = "Book Author 5" });

            return View(books);
        }
    }
}
