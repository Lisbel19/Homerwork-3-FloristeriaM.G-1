using Microsoft.AspNetCore.Mvc;

namespace FloristeriaM.G.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        [HttpGet]
        public string Get() => "Formulario de Login Inicializado";
    }
}
