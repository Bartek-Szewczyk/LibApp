using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibApp.Data;
using LibApp.Models;
using LibApp.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace LibApp.Controllers
{
    public class BooksController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BooksController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Random()
        {
            var firstBook = new Book { Name = "English dictionary" };

            var customers = new List<Customer>
            {
                new Customer{Name = "Customer 1"},
                new Customer{Name = "Customer 2"}
            };

            var viewModel = new RandomBookViewModel
            {
                Book = firstBook,
                Customers = customers
            };

            return View(viewModel);
        }
        
        public IActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        public IActionResult Index()
        {
            var books = _context.Book
                .Include(b => b.Genre)
                .ToList();
            return View(books);
        }

        public IActionResult Details(int id)
        {
            var book = _context.Book
                .Include(b => b.Genre)
                .SingleOrDefault(b => b.Id == id);
            return View(book);
        }

        [Route("books/released/{year:regex(^\\d{{4}}$)}/{month:range(1,12)}")]
        public IActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
        
        private IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() { Id = 1, Name = "Hamlet" },
                new Book() { Id = 2, Name = "Ulysses" }

            };

        }
    }
}
