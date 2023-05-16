using Microsoft.AspNetCore.Mvc;
using Polizas.Auth;
using Polizas.Core.Entities;

namespace Polizas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : BaseController
    {
        private readonly IJwtAuthenticationService _authService;

        public AuthController(IJwtAuthenticationService authService)
        {
            _authService = authService ?? throw new ArgumentNullException(nameof(authService));
        }

        [HttpPost]
        public IActionResult Authenticate([FromBody] AuthInfo user)
        {
            if (user.Username.Equals("test") && user.Username.Equals("test"))
            {
                var token = _authService.Authenticate(new Random().Next().ToString());
                if (token == null)
                    return Unauthorized();
                return Ok(token);
            }
            return Unauthorized();
        }
    }
}
