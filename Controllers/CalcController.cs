using Microsoft.AspNetCore.Mvc;

namespace WebApplication26.Controllers
{
    [Route("api/calc")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [HttpPost("add")]
        public IActionResult Add([FromBody] int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return BadRequest(new { message = "No numbers provided." });

            int sum = 0;
            foreach (var number in numbers)
                sum += number;

            return Ok(new { result = sum });
        }

        [HttpPost("subtract")]
        public IActionResult Subtract([FromBody] int[] numbers)
        {
            if (numbers == null || numbers.Length < 2)
                return BadRequest(new { message = "At least two numbers are required." });

            int result = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
                result -= numbers[i];

            return Ok(new { result = result });
        }

        [HttpPost("multiply")]
        public IActionResult Multiply([FromBody] int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return BadRequest(new { message = "No numbers provided." });

            int product = 1;
            foreach (var number in numbers)
                product *= number;

            return Ok(new { result = product });
        }

        [HttpPost("devide")]
        public IActionResult Divide([FromBody] int[] numbers)
        {
            if (numbers == null || numbers.Length < 2)
                return BadRequest(new { message = "At least two numbers are required." });

            double result = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == 0)
                    return BadRequest(new { message = "Division by zero is not allowed." });
                result /= numbers[i];
            }

            return Ok(new { result = result });
        }
    }
}