using Microsoft.EntityFrameworkCore;

namespace Bookstore.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

    }

    public class BookDBContext : DbContext
    {
        public DbSet<BookModel> Books { get; set; }
    }

    // https://learn.microsoft.com/pl-pl/aspnet/mvc/overview/getting-started/introduction/creating-a-connection-string
}
