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

            SaveCalculation($"Addition of {string.Join(", ", numbers)} = {sum}");
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

            SaveCalculation($"Subtraction of {string.Join(", ", numbers)} = {result}");
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

            SaveCalculation($"Multiplication of {string.Join(", ", numbers)} = {product}");
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

            SaveCalculation($"Division of {string.Join(", ", numbers)} = {result}");
            return Ok(new { result = result });
        }

        private static void SaveCalculation(string calculationData)
        {
            var filePath = Path.Combine("/app/data", "calculation.txt");
            var data = System.IO.File.Exists(filePath) ? System.IO.File.ReadAllText(filePath) : string.Empty;
            System.IO.File.WriteAllText(filePath, data + '\n' + calculationData);
            Console.WriteLine("Data saved - " + calculationData);
        }
    }
}