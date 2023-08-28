using lctp.core.Services;
using lctp.libs.Models;
using Microsoft.AspNetCore.Mvc;

namespace lctp.api.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly LoginService _loginService;

        public LoginController(LoginService loginService)
        {
            _loginService = loginService;
        }
        [HttpPost]
        [Route("login")]
        public async Task<ActionResult<dynamic>> Authenticate([FromBody] UserModel user)
        {
            var userdb = await _loginService.GetUser();
            return Ok(userdb);
        }
    }
}
