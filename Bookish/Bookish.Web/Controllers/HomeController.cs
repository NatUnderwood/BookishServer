using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bookish.DataAccess;

namespace Bookish.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var dataInterpreter = new DataInterpreter();
            ViewBag.BorrowedBooks = dataInterpreter.GetBorrowedBooks();
            
            return View();
        }

        public ActionResult Browse()
        {
            var dataInterpreter = new DataInterpreter();
            ViewBag.Books = dataInterpreter.GetAlphabeticalBooks();

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Book()
        {
            var dataInterpreter = new DataInterpreter();
            ViewBag.Book = 1;

            return View();
        }

        public void FindBook(object sender, EventArgs e)
        {
            Console.WriteLine(e);
        }
    }
}