using Microsoft.AspNetCore.Mvc;
public class LifeController : Controller
{
 public ActionResult Index()
 {
 return Ok("This index of the LifeController");
 }
 public ActionResult Quote()
 {
 return Ok("This quote of the LifeController");
 }
}