using Microsoft.AspNetCore.Mvc;
public class CustomercareController : Controller
{ 
 public ActionResult Index()
 {
 return Ok("This index of the Customercare");
 }
  [Route("Customercare/Claims")]
 public ActionResult Quote()
 {
      return Ok("This is Quote of the Customercare");
 }
}