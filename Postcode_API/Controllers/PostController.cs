using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Postcode_API.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Postcode_API.Controllers
{
    public class PostController : Controller
    {

        public PostController(string url)
        {

        }
        [HttpGet]
        public async Task<ActionResult<string>> PostPostCode(string userPostCode)
        {
            using(var client = new HttpClient())
            {

                string endpoint = $"https://api.postcodes.io/postcodes/{userPostCode}/validate";

                string result = await client.GetAsync(endpoint).Result.Content.ReadAsStringAsync();

                return result;
            }

        }
    }
}
