using DbFirst.BussinessLogic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DbFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DbController : ControllerBase
    {
        private IDbLogic _db;
        public DbController(IDbLogic db) { 
        _db = db;
        }   

        [HttpGet("getAllBooks")]
        public IActionResult AllBooks()
        {
            var response= _db.getAllBooks();

            return Ok(response);
        }
    }
}
