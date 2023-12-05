using DbFirst.Models;

namespace DbFirst.BussinessLogic
{
    public class DbLogic : IDbLogic
    {
        private BooksBorrowingDbContext _db;
        public DbLogic(BooksBorrowingDbContext dbContext)
        {
            _db = dbContext;
        }

        public List<BookDetail> getAllBooks()
        {
            return _db.BookDetails.ToList();
        }

    }
}
