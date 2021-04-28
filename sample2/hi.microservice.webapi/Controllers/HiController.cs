using Dapr;
using Microsoft.AspNetCore.Mvc;
using System;

namespace hi.microservice.webapi.Controllers
{
    [ApiController]
    public class HiController : ControllerBase
    {
        [HttpGet("hi")]
        public ActionResult<string> Get()
        {
            var message = "Hi Sample 2";
            Console.WriteLine(message);
            return message;
        }
    }
}