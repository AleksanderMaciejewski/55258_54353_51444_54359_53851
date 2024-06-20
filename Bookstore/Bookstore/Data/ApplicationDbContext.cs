using Bookstore.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bookstore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<BookModel> Books { get; set; }
        public DbSet<ClientModel> Clients { get; set; }
        public DbSet<OrderedBookModel> OrderedBooks { get; set; }
        public DbSet<SoldBookModel> SoldBooks { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
