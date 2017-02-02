using Microsoft.AspNetCore.Mvc;
public class XhomeController : Controller
{
[Route("Home")]
 public ActionResult Index()
 {
 return Ok("This index of the XhomeController");
 }
 [Route("Home/Quote")]
 public ActionResult Quote()
 {
 return Ok("This Quote of the XhomeController");
 }
}