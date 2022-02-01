using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleToWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        [Route("{id:int:min(10):max(100)}")]
        public string GetById(int id)
        {
            return $"book int: {id}";
        }

        [Route("{id:alpha:min(10)}")]
        public string GetByStringId(string id)
        {
            return $"book string: {id}";
        }

        [Route("{id:regex(a(b|c))}")]
        public string GetByRegexId(string id)
        {
            return $"book regex: {id}";
        }
    }
}
