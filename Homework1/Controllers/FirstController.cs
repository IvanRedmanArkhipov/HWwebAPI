using System;
using Homework1;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Homework1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FirstController : ControllerBase
    {
        private readonly ValuesHolder _holder;

        public FirstController (ValuesHolder holder)
        {
            _holder = holder;
        }

        [HttpPost("create")]
        public IActionResult Create ([FromBody] WeatherValue input)
        {
            _holder.Add(input);
            return Ok();
        }

        [HttpGet("read")]
        public IActionResult Read()
        {
            return Ok(_holder.Get());
        }

        [HttpPut("update")]
        public IActionResult Update([FromBody] WeatherValue input)
        {
            return Ok();
        }

        [HttpDelete("delete")]
        public IActionResult Delete([FromQuery] DateTime date)
        {
            return Ok();
        }
    }
}
