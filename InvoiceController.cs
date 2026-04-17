using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BuggyApp.Controllers
{
    [ApiController]
    [Route("api/invoice")]
    public class InvoiceController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetInvoice()
        {
            var items = new List<Item>
            {
                new Item { name = "Web Design", price = 2000.00 },
                new Item { name = "Hosting", price = 900.00 },
                new Item { name = "Domain Registration", price = 500.00 }
            };

            return Ok(new { items = items });
        }

        public class Item
        {
            public string name { get; set; } = string.Empty;
            public double price { get; set; }
        }
    }
}
