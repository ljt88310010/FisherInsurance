using Microsoft.AspNetCore.Mvc;
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
            return View();
            //return Ok("This is the quote of the LifeController");
        }
    }
}