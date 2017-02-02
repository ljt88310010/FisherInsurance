using Microsoft.AspNetCore.Mvc;
public class LifeController : Controller
{
 public ActionResult Index()
 {
 return Ok("This index of the HomeController");
 }
 public ActionResult Quote()
 {
 return Ok("This index of the HomeController");
 }
}