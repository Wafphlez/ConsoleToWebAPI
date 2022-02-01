using ConsoleToWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleToWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        [Route("")]
        public EmployeeModel GetEmployees()
        {
            return new EmployeeModel() { Id = 1, Name = "Worker" };
        }

        [Route("{id}")]
        public IActionResult GetEmployees(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            return Ok(new EmployeeModel() { Id = 1, Name = "Worker" });
        }

        [Route("{id}/basic")]
        public ActionResult<EmployeeModel> GetEmployeesBasicDetails(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            return new EmployeeModel() { Id = 1, Name = "Worker" };
        }
    }
}
