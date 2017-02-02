using Microsoft.AspNetCore.Mvc;
public class HomeController : Controller
{
 public ActionResult Index()
 {
 return Ok("This index of the HomeController");
 }
}