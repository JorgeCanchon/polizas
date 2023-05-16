using Microsoft.AspNetCore.Mvc;
using Polizas.Core.Entities;

namespace Polizas.Controllers
{
    public class BaseController : Controller
    {
        protected IActionResult GetStatus(int status, Response response)
        {
            switch (status)
            {
                case 200:
                    return Ok(response);
                case 201:
                    return Ok(response);
                case 202:
                    return Accepted(response);
                case 400:
                    return BadRequest(response);
                case 404:
                    return NotFound(response);
                case 500:
                    return Problem(response.Message);
                default:
                    return StatusCode(response.Status, response);
            }
        }
    }
}
