using Microsoft.AspNetCore.Mvc;
public class AutoController : Controller
{
 public ActionResult Index()
 {
 return Ok("This index of the AutoController");
 }
 public ActionResult Quote()
 {
            return Ok("This quote of the AutoController");
 }
}