using BackgroundJobs.Schedules;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace HangFireDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            //FireAndForgetJobs.ProductLogJob(product);
            //DelayedJobs.ProductAddedSendEmail(product);
            RecurringJobs.AddedProductInfo();
            return Ok(product);
        }
    }
}
