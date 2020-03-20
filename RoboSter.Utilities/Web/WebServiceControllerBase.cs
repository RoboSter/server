using Microsoft.AspNetCore.Mvc;

namespace RoboSter.Utilities.Web
{
    [ApiController]
    public class WebServiceControllerBase : ControllerBase
    {
        protected JsonResult Json(object obj) => new JsonResult(obj);
    }
}