using Microsoft.AspNetCore.Mvc;
using RoboSter.Utilities.Helpers;

namespace RoboSter.Utilities.Web
{
    [ApiController]
    public class WebServiceControllerBase : ControllerBase
    {
        protected JsonResult Json(object obj) => new JsonResult(obj, JsonHelper.DefaultSerializerSettings);
    }
}