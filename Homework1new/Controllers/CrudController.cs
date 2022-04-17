using Microsoft.AspNetCore.Mvc;

namespace Homework1new.Controllers
{
    public class CrudController : Controller
    {
        private readonly ValuesHolder _holder;
        public CrudController(ValuesHolder holder)
        {
            _holder = holder;
        }
        [HttpPost("create")]
        public IActionResult Create([FromQuery] string input)
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
        public IActionResult Update([FromQuery] string stringsToUpdate,
        [FromQuery] string newValue)
        {
            _holder.Update(stringsToUpdate, newValue);
            return Ok();
        }
        [HttpDelete("delete")]
        public IActionResult Delete([FromQuery] string stringsToDelete)
        {
            _holder.Delete(stringsToDelete);
            return Ok();
        }        
    }
}
