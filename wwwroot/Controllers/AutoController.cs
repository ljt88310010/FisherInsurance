using Microsoft.AspNetCore.Mvc;
namespace FisherInsurance.Controllers
{
    public class AutoController : Controller
    {
        public ActionResult Index()
        {
            return Ok("This is the index of the AutoController");
        }
        public ActionResult Quote()
        {
            return Ok("This is the quote of the AutoController");
        }
    }
}