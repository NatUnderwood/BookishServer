﻿namespace Bookish.DataAccess
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Isbn { get; set; }
        public string Author { get; set; }

        public override string ToString()
        {
            return Title + " " + Author + " " + Isbn;
        }
    }
}