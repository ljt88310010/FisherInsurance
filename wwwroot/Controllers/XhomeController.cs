using Microsoft.AspNetCore.Mvc;
namespace FisherInsurance.Controllers
{
    public class XhomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
            //return Ok("This is the index of the XhomeController");
        }
        public ActionResult Quote()
        {
            return View();
            //return Ok("This is the Quote of the XhomeController");
        }
    }
}