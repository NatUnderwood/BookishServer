using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Bookish
{
    class Program
    {
        static void Main(string[] args)
        {
            IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["BookishConnection"].ConnectionString);
            string SqlString = "SELECT TOP 3 [BookId],[Title],[Author],[ISBN] FROM [Book]";
            var books = (List<Book>)db.Query<Book>(SqlString);
            foreach (var book in books)
            {
                Console.WriteLine("THIS ACTUALLY WORKED");
            }
        }
    }
}
