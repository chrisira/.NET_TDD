using Domain;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {

        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet("Add/{left}/{right}")]
        public int Get(int left,int right)
        {
            var calculator = new Calculator();
            return calculator.Sum(left,right);
           
        }
    }
}