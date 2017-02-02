using Microsoft.AspNetCore.Mvc;
public class LifeController : Controller
{
 public ActionResult Index()
 {
 return Ok("This is the index of the LifeController");
 }
 public ActionResult Quote()
 {
 return Ok("This is the quote of the LifeController");
 }
}