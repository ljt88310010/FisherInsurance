using Microsoft.AspNetCore.Mvc;
namespace FisherInsurance.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return Ok("This is the index of the HomeController");
        }
    }
}