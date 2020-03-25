using Microsoft.AspNetCore.Mvc;

namespace TesterClubPagoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<string> Get()
        {
            return $"CLUB PAGO API >>>> MX - {System.DateTime.Now}";
        }
    }
}

