using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Postcode_API.Controllers;

namespace Postcode_API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string url = Console.ReadLine();

            PostController test = new PostController(url);

            Task<ActionResult<string>> result = test.PostPostCode(url);

            Console.WriteLine(result);
            //string userPostCode = Console.ReadLine();

            //    using (var client = new HttpClient())
            //    {

            //        string endpoint = $"https://api.postcodes.io/postcodes/{userPostCode}/validate";

            //        string result = client.GetAsync(endpoint).Result.Content.ReadAsStringAsync().Result;

            //    Console.WriteLine(result);

            //    Console.Read();


            // 1. Create an enpoint

            // 2. Allow it to recieve a any body of json -> dynamic type? 

            // 3. On recieving json parse out postcode from body

            // 4. Make a get request to external api

            // 5. If result is true then return an okay status code else create a status code and send it back.

            
        }
    }
}
