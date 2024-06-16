using Microsoft.EntityFrameworkCore;

namespace Bookstore.Models
{
    public class SoldBookModel
    {
        public int BookId { get; set; }
        public DateTime SellingBookDate { get; set; }

    }
}