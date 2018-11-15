using System;
using System.Collections.Generic;
using System.Linq;
using Bookish.DataAccess;

namespace Bookish
{
    public class DataInterpreter
    {
        public List<BorrowedBook> GetBorrowedBooks()
        {
            var dataAccessor = new DataAccessor();
            var booksList = dataAccessor.GetBooks();
            var barcodeBooksDict = dataAccessor.GetBarcodeBooks();
            var barcodeUserList = dataAccessor.GetBarcodeUsers();
            var borrowedBooks = new List<BorrowedBook>();
            foreach (var barcodeUser in barcodeUserList)
            {
                var bookId = barcodeBooksDict[barcodeUser.Barcode];
                var bookTitle = MakeBookDict(booksList)[bookId].Title;
                var bookAuthor =  MakeBookDict(booksList)[bookId].Author;
                borrowedBooks.Add(new BorrowedBook(bookAuthor,bookTitle,barcodeUser.ReturnDate));
            }

            return borrowedBooks;
        }

        public List<Book> GetAlphabeticalBooks()
        {
            var dataAccessor = new DataAccessor();
            var booksList = dataAccessor.GetBooks();
            booksList = booksList.OrderBy(b => b.Title).ToList();
            return booksList;
        }

        private Dictionary<int, Book> MakeBookDict(List<Book> bookList)
        {
            var bookDictionary= new Dictionary<int,Book>();
            foreach (var book in bookList)
            {
                bookDictionary.Add(book.BookId, book);
            }

            return bookDictionary;
        }
    }
}