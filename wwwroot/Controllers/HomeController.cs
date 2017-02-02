using Microsoft.AspNetCore.Mvc;
public class HomeController : Controller
{
 public ActionResult Index()
 {
 return Ok("This is the index of the HomeController");
 }
}