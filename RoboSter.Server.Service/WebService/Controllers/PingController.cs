using Microsoft.AspNetCore.Mvc;
using RoboSter.Utilities.Web;

namespace RoboSter.Server.Service.WebService.Controllers
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