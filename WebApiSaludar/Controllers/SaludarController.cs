using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiSaludar.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class SaludarController : ControllerBase {
        [HttpGet]
        public string Get() {
            return "Hola Gabriel!!!!!!!22222";
        }

    }
}
