using System;

namespace WebAPI
{
    [Route("api/[Controller]")]
    class Program
    {
        [HttpGet]
        public IActionResult GetAll()
        { return Content ("Say Hello!")
        }
    }
} 