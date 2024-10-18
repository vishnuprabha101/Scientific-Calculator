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

        [HttpGet("divide")]
        public IActionResult Divide(int a, int b)
        {
            if (b == 0)
                return BadRequest("Cannot divide by zero.");
            return Ok(_calculatorService.Divide(a, b));
        }

        
        
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

         [HttpGet("exponent")]
        public IActionResult Exponent(double x)
        {
            var result = _calculatorService.Exponent(x);
            return Ok(result);
        }

         [HttpGet("modulus")]
        public IActionResult Modulus(int a, int b)
        {
            if (b == 0)
                return BadRequest("Cannot perform modulus with a divisor of zero.");
            var result = _calculatorService.Modulus(a, b);
            return Ok(result);
        }
        // Add the factorial method
        [HttpGet("factorial")]
        public ActionResult<double> Factorial(int n)
        {
            if (n < 0)
            {
                 return BadRequest("Factorial of a negative number is not defined.");
             }
            return _calculatorService.Factorial(n);
        }


    }
}
