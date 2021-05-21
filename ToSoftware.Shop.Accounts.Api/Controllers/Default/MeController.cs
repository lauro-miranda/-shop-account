using Microsoft.AspNetCore.Mvc;

namespace ToSoftware.Shop.Accounts.Api.Controllers.Default
{
    [ApiController, Route("")]
    public class MeController : ControllerBase
    {
        [HttpGet, Route("")]
        public IActionResult Get() => Ok(new { name = "shop account", version = "1.0" });
    }
}