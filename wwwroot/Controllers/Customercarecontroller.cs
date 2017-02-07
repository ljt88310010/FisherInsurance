using Microsoft.AspNetCore.Mvc;

namespace FisherInsurance.Controllers
{
    [Route("claim")]
    public class CustomercareController : Controller
    { 
        public ActionResult Index()
        {
        return Ok("This is the index of the Customercare");
        }
        [Route("Quote")]
        public ActionResult Quote()
        {
            return Ok("This is the Quote of the Customercare");
        }
        [Route("fileclaim")]
        public ActionResult NewClaim()
        {
            return Ok("This is the NewClaim of the Customercare");
        }
        [Route("claimstatus")]
        [Route("myclaims")]
        public ActionResult ClaimHistory()
        {
            return Ok("This is the ClaimHistory of the Customercare");
        }
    }
}