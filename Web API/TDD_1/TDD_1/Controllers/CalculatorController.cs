using Microsoft.AspNetCore.Mvc;
using TDD_1.Services;

namespace TDD_1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly CalculatorService _service = new CalculatorService();
      
        [HttpGet("add")]
        public IActionResult Add(int a, int b)
        {
            return Ok(_service.Add(a, b));
        }

    }
}
