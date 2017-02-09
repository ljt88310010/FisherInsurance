using Microsoft.AspNetCore.Mvc;
namespace FisherInsurance.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //return Ok("This is the index of the HomeController");
            return View();
        }
    }
}