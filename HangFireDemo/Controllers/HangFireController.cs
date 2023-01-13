using Hangfire;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace HangFireDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HangFireController : ControllerBase
    {
        [HttpGet]
        public IActionResult Action()
        {
            RecurringJob.AddOrUpdate("testJobu", () => Console.WriteLine("Job Çalıştı"), "* * * * *");

            //BackgroundJob.Enqueue(() => Console.WriteLine("Hello, world!"));
            return Ok("Action");
        }

    }
}
