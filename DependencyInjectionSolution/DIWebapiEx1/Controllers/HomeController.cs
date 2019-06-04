using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyEx1;
using DIWebapiEx1.DominClass;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DIWebapiEx1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private IPaymentService _PaymentService;

        // GET: api/Home
        [HttpGet]
        public IEnumerable<string> Get()
        {
            PaymentProvider _provider = new PaymentProvider("Paypal");
            var message = _provider._paymentService.PaymentMessage();
            return new string[] { message.Status, message.Error };
        }

        // GET: api/Home/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Home
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Home/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
