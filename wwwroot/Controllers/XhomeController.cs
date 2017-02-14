using Microsoft.AspNetCore.Mvc;
using FisherInsurance.Models;
using System;
namespace FisherInsurance.Controllers
{
    [Route("homeinsurance")]
    public class XhomeController : Controller
    {
        [RouteAttribute("")]
        public ActionResult Index()
        {
            return View();
            //return Ok("This is the index of the XhomeController");
        }
        [RouteAttribute("quote")]
        public ActionResult Quote()
        {
            Quote quote = new Quote
            {
            Id = 345,
            Product = "Home Insurance",
            ExpireDate = DateTime.Now.AddDays(45),
            Price = 45.00M
            };
            return View(quote);
            //return Ok("This is the Quote of the XhomeController");
        }
    }
}