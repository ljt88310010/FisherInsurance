using Microsoft.AspNetCore.Mvc;
using System;
using FisherInsurance.Models;
namespace FisherInsurance.Controllers
{
    public class LifeController : Controller
    {
        public ActionResult Index()
        {
            return View();
            //return Ok("This is the index of the LifeController");
        }
        public ActionResult Quote()
        {
            Quote quote = new Quote
            {
            Id = 345,
            Product = "Life Insurance",
            ExpireDate = DateTime.Now.AddDays(45),
            Price = 45.00M
            };
            return View(quote);
            //return Ok("This is the quote of the LifeController");
        }
    }
}