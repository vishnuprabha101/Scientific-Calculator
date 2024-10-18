using Calculator.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Calculator.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ICalculatorService<int> _calculatorService;

        public CalculatorController(ICalculatorService<int> calculatorService)
        {
            _calculatorService = calculatorService;
        }

        // Basic Arithmetic Operations
        [HttpGet("add")]
        public IActionResult Add(int a, int b) => Ok(_calculatorService.Add(a, b));

        [HttpGet("subtract")]
        public IActionResult Subtract(int a, int b) => Ok(_calculatorService.Subtract(a, b));   

         [HttpGet("multiply")]
        public IActionResult Multiply(int a, int b) => Ok(_calculatorService.Multiply(a, b));
        
        
        // Scientific Operations





        [HttpGet("squareRoot")]
        public IActionResult SquareRoot(double a)
        {
            if (a < 0)
                return BadRequest("Cannot calculate square root of a negative number.");
            var result = _calculatorService.SquareRoot(a);
            return Ok(result);
        }

       [HttpGet("power")]
        public IActionResult Power(double baseValue, double exponent)
        {
            var result = _calculatorService.Power(baseValue, exponent);
            return Ok(result);
        }

        [HttpGet("percentage")]
        public IActionResult Percentage(double total, double percentage)
        {
            var result = _calculatorService.Percentage(total, percentage);
            return Ok(result);
        }
        
    }
}
