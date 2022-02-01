using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleToWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ValuesController : ControllerBase
    {
        [Route("api/all")]
        [Route("api/get-all")]
        public string GetAll()
        {
            return "GetAll";
        }

        [Route("~/api/authors")]
        public string GetAllAuthors()
        {
            return "All authors";
        }

        [Route("{id}")]
        public string GetById(int id)
        {
            return $"id {id}";
        }
        

        [Route("search")]
        public string SearchBooks(int id, string name, float rating)
        {
            return $"id {id}, name {name}, rating {rating}";
        }

    }
}
