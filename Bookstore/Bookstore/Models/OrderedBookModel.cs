namespace Bookstore.Models
{
    public class OrderedBookModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public BookModel Book { get; set; }
        public ClientModel Client { get; set; }
    }
}
