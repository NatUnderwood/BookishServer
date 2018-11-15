using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookish.DataAccess;
using Dapper;

namespace Bookish
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataAccessor= new DataAccessor();
            var bookList = dataAccessor.GetBooks();
            foreach (var book in bookList)
            {
                Console.WriteLine(book.ToString()+"\n");
            }
        }
    }
}
