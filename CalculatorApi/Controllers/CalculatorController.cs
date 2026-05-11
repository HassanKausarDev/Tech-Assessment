using CalculatorApi.Models;
using CalculatorLibrary;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ISimpleCalculator _calculator;

        public CalculatorController(ISimpleCalculator calculator)
        {
            _calculator = calculator;
        }

        [HttpPost("add")]
        public IActionResult Add([FromBody] CalculatorRequest request)
        {
            try
            {
                var result = _calculator.Add(request.Start, request.Amount);

                return Ok(new { result });
            }
            catch (OverflowException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("subtract")]
        public IActionResult Subtract([FromBody] CalculatorRequest request)
        {
            try
            {
                var result = _calculator.Subtract(request.Start, request.Amount);

                return Ok(new { result });
            }
            catch (OverflowException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}