using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleToWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        List<AnimalModel> animals = new List<AnimalModel>()
        {

                new AnimalModel(){ Id = 1, Name = "Wolf" },
                new AnimalModel(){ Id = 2, Name = "Dog" }
        };

        public IActionResult GetAnimals()
        {
            return Ok(animals);
        }

        [Route("test")]
        public IActionResult GetAnimalsTest()
        {
            return AcceptedAtAction("Animals");
        }

        [Route("{id:int}")]
        public IActionResult GetAnimalsById(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            return Ok(animals.FirstOrDefault(i => i.Id == id));
        }

        //[HttpPost("")]
        //public IActionResult AnimalsTest(AnimalModel animal)
        //{
        //    animals.Add(animal);

        //    return Created($"~/api/animals/{animal.Id}", new { animal });
        //}

        [HttpPost("")]
        public IActionResult AnimalsTest(AnimalModel animal)
        {
            animals.Add(animal);

            return CreatedAtAction("GetAnimalsById", new { id = animal.Id }, new { animal });
        }
    }
}
