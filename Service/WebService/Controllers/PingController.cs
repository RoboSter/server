using Microsoft.AspNetCore.Mvc;
using Utilities.Web;

namespace Service.WebService.Controllers
{
    public class PingController : WebServiceControllerBase
    {
        [Route("")]
        [Route("ping")]
        [HttpGet]
        [HttpPost]
        [HttpPut]
        [HttpDelete]
        public ActionResult Ping()
        {
            return Json(new
            {
                method = HttpContext.Request.Method
            });
        }
    }
}