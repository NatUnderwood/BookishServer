using System;

namespace Bookish.DataAccess
{
    public class BorrowedBook
    {
        public BorrowedBook(string author, string title, DateTime returnDate)
        {
            Author = author;
            Title = title;
            ReturnDate = returnDate;
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}