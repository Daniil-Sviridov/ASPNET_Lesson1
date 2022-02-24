using Microsoft.AspNetCore.Mvc;
using System.Linq;


namespace WebApplication1.Controllers
{

    [ApiController]
    [Route("api/crud")]
    public class CrudController : ControllerBase
    {
        private readonly ValuesHolder _holder;
        private readonly ILogger<WeatherForecastController> _logger;

        public CrudController(ILogger<WeatherForecastController> logger, ValuesHolder holder)
        {
            _logger = logger;
            _holder = holder;
        }

        [HttpPost("create")]
        public IActionResult Create([FromQuery] DateTime date, [FromQuery] string? input, [FromQuery] int tempr)
        {
            _holder.Add(date, input, tempr);
            return Ok();
        }

       /* [HttpPost("create")]
        public IActionResult Create([FromQuery] string input, [FromQuery] int tempr)
        {
            _holder.Add(input, tempr);
            return Ok();
        }*/

        [HttpGet("read")]
        public IActionResult Read([FromQuery] DateTime dateFrom, [FromQuery] DateTime dateBefore)
        {
            return Ok(_holder.Get(dateFrom, dateBefore));
        }

        [HttpPut("update")]
        public IActionResult Update([FromQuery] DateTime dateToUpdate, [FromQuery] int newValue)
        {
            for (int i = 0; i < _holder.Values.Count; i++)
            {
                if (_holder.Values[i].Date == dateToUpdate)
                {
                    _holder.Values[i].TemperatureC = newValue;
                }
            }

            return NoContent();
        }

        [HttpDelete("delete")]
        public IActionResult Delete([FromQuery] DateTime dateToDelete)
        {
            _holder.Values = _holder.Values.Where( f => f.Date != dateToDelete).ToList();
            return NoContent();


        }
    }

}