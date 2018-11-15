using System;

namespace Bookish.DataAccess
{
    public class BarcodeUser
    {
        public int UserId { get; set; }
        public string Barcode { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}