using DbFirst.Models;

namespace DbFirst.BussinessLogic
{
    public interface IDbLogic
    {
        List<BookDetail> getAllBooks();
    }
}