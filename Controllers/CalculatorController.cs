using Microsoft.AspNetCore.Mvc;
using webservicedotnet.Utils;

namespace webservicedotnet.Controllers
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

        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Sum(string firstNumber, string secondNumber)
        {
            if (UtilsConvert.IsNumeric(firstNumber) && UtilsConvert.IsNumeric(secondNumber))
            {
                var sum = UtilsConvert.ConvertToDecimal(firstNumber) + UtilsConvert.ConvertToDecimal(secondNumber);
                return Ok(sum);
            }
            return BadRequest("Invalid Input");
        }

        [HttpGet("substract/{firstNumber}/{secondNumber}")]
        public IActionResult Substract(string firstNumber, string secondNumber)
        {
            if (UtilsConvert.IsNumeric(firstNumber) && UtilsConvert.IsNumeric(secondNumber))
            {
                var substract = UtilsConvert.ConvertToDecimal(firstNumber) - UtilsConvert.ConvertToDecimal(secondNumber);
                return Ok(substract);
            }
            return BadRequest("Invalid Input");
        }

        [HttpGet("divide/{firstNumber}/{secondNumber}")]
        public IActionResult Divide(string firstNumber, string secondNumber)
        {
            if (UtilsConvert.IsNumeric(firstNumber) && UtilsConvert.IsNumeric(secondNumber))
            {
                if(Utils.UtilsConvert.ConvertToDecimal(secondNumber) == 0)
                {
                    return BadRequest("Invalid Input: None number can be divided by 0");
                }
                var divide = UtilsConvert.ConvertToDecimal(firstNumber) / UtilsConvert.ConvertToDecimal(secondNumber);
                return Ok(divide);
            }
            return BadRequest("Invalid Input");
        }
    }
}