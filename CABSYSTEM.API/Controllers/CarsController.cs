using Microsoft.AspNetCore.Mvc;

namespace CABSYSTEM.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCars()
        {
            return Ok(new[]
            {
                new { Id = 1, Brand = "Toyota", Model = "Vios", Price = 520000000 },
                new { Id = 2, Brand = "Honda", Model = "City", Price = 610000000 }
            });
        }
    }
}