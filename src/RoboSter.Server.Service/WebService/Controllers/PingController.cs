using Microsoft.AspNetCore.Mvc;
using RoboSter.Utilities.Configuration;
using RoboSter.Utilities.Web;

namespace RoboSter.Server.Service.WebService.Controllers
{
    public class PingController : WebServiceControllerBase
    {
        private readonly IConfig config;

        public PingController(IConfig config)
        {
            this.config = config;
        }

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
                method = HttpContext.Request.Method,
                isProduction = config.IsProduction()
            });
        }
    }
}