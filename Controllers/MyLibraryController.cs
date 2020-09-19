using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Dropbox03.Controllers
{
    public class MyLibraryController : Controller
    { 
        // GET: /<controller>/
        static List<string> allBooks = new List<string> { "Java Basic", "Agile with C#", "Advanced Agile" };
        
        public IActionResult Book()
        {
        ViewData["Books"] = allBooks;
        return View();
        }
        public IActionResult AddBook()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddBook(string bookTitle)
        {
            allBooks.Add(bookTitle);
            return RedirectToAction("Book", "MyLibrary");
        }
    }
}
