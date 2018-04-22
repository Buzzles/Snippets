using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CombinedLanguageExampleApi.Controllers
{
    [Route("api/[controller]")]
    public class HelloWorldController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        [HttpGet]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [Route("HelloPost")]
        [HttpPost]
        public string HelloPost([FromBody] string value)
        {
            return value;
        }
    }
}