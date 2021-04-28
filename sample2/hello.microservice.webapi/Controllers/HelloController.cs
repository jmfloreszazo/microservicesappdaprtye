using Dapr;
using Microsoft.AspNetCore.Mvc;
using System;

namespace hello.microservice.webapi.Controllers
{
    [ApiController]
    public class HelloController : ControllerBase
    {
        [HttpGet("hello")]
        public ActionResult<string> Get()
        {
            var message = "Hello Sample 2";
            Console.WriteLine(message);
            return message;
        }
    }
}