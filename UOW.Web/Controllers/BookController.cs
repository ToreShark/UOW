using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UOW.BLL.uow;
using UOW.DAL.Entities;

namespace UOW.Web.Controllers
{
    public class BookController : Controller
    {
        private readonly UnitOfWork _uow;

        public BookController(UnitOfWork uow)
        {
            _uow = uow;
        }

        public IActionResult Index()
        {
            IEnumerable<Book> books = _uow.BookRepository.Get();
            return View(books);
        }

        public IActionResult Details(int id)
        {
            Guid guidId = new Guid(id.ToString());
            Book book = _uow.BookRepository.GetById(guidId);
            return View(book);
        }
        
        public IActionResult Name(string bookName)
        {
            Book book = _uow.BookRepository.GetByName(bookName);
            return View(book);
        }
        
        public IActionResult Order(int id)
        {
            Guid guidId = new Guid(id.ToString());
            Orders order = _uow.OrderRepository.GetById(guidId);
            return View();
        }
    }
}