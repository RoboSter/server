using Microsoft.AspNetCore.Mvc;

namespace Utilities.Web
{
    [ApiController]
    public class WebServiceControllerBase : ControllerBase
    {
        protected JsonResult Json(object obj) => new JsonResult(obj);
    }
}