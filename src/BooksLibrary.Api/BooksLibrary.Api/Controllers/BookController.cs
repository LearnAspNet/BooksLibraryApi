using Microsoft.AspNetCore.Mvc;

namespace BooksLibrary.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        public async Task<IActionResult> GetBooks()
        {
            return await Task.FromResult(Ok());
        } 
    }
}
