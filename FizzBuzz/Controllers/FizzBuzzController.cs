using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FizzBuzz.Domain;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FizzBuzz.Controllers
{
    public class FizzBuzzController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult OnSubmitCalculateFizzBuzz(string[] inputArray)
        {
            var fizzBuzzResponse = FizzBuzzHelper.CalculateFizzBuzz(inputArray);
            return Json(fizzBuzzResponse);
        }
    }
}
