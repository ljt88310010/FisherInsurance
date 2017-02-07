using Microsoft.AspNetCore.Mvc;
namespace FisherInsurance.Controllers
{
    [Route("home")]
    public class XhomeController : Controller
    {
        public ActionResult Index()
        {
        return Ok("This is the index of the XhomeController");
        }
        [Route("Home/Quote")]
        public ActionResult Quote()
        {
        return Ok("This is the Quote of the XhomeController");
        }
    }
}