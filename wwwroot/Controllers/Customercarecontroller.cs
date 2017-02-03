using Microsoft.AspNetCore.Mvc;

public class CustomercareController : Controller
{ 
 [Route("customer")]
 [Route("customer/Index")]
 public ActionResult Index()
 {
 return Ok("This is the index of the Customercare");
 }
  [Route("customer/Claims")]
 public ActionResult Quote()
 {
      return Ok("This is the Quote of the Customercare");
 }
 [Route("customer/claim/fileclaim")]
 [Route("customer/fileclaim")]
 public ActionResult NewClaim()
 {
      return Ok("This is the NewClaim of the Customercare");
 }
 [Route("customer/claimstatus")]
 [Route("customer/claim/myclaims")]
 public ActionResult ClaimHistory()
 {
      return Ok("This is the ClaimHistory of the Customercare");
 }
}