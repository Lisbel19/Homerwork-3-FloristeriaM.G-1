using Microsoft.AspNetCore.Mvc;

namespace FloristeriaM.G.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DashboardController : ControllerBase
    {
        [HttpGet]
        public string Get() => "Panel de control de usuario cargado correctamente";
    }
}
