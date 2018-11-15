using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;

namespace Bookish.DataAccess
{
    public class DataAccessor
    {
        public List<Book> GetBooks()
        {
            IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["BookishWebConnection"].ConnectionString);
            var SqlString = "SELECT TOP 3 [BookId],[Title],[Author],[ISBN] FROM [Book]";
            return db.Query<Book>(SqlString).ToList();
        }

        public Dictionary<string,int> GetBarcodeBooks()
        {
            IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["BookishWebConnection"].ConnectionString);
            var SqlString = "SELECT TOP 3 [BookId],[Barcode] FROM [BarcodeBook]";
            return db.Query<BarcodeBook>(SqlString).ToDictionary(x=>x.Barcode, x=>x.BookId);
        }

        public List<BarcodeUser> GetBarcodeUsers()
        {
            IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["BookishWebConnection"].ConnectionString);
            var SqlString = "SELECT TOP 3 [UserId],[Barcode],[ReturnDate] FROM [BarcodeUser]";
            return db.Query<BarcodeUser>(SqlString).ToList();
        }

        
    }
}