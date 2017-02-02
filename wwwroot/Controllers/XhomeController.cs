using Microsoft.AspNetCore.Mvc;
public class XhomeController : Controller
{
[Route("Home")]
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