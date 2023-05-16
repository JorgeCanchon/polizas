using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Polizas.Core.Entities;
using Polizas.Core.Interfaces.UsesCases;

namespace Polizas.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class PolizaController : BaseController
    {
        private readonly IPolizaInteractor _polizaInteractor;

        public PolizaController(IPolizaInteractor polizaInteractor)
        {
            _polizaInteractor = polizaInteractor ?? throw new ArgumentNullException(nameof(polizaInteractor));
        }

        [HttpGet("{query}")]
        public IActionResult Get(string query)
        {
            Response response = _polizaInteractor.GetPoliza(query);
            return GetStatus(response.Status, response);
        }

        [HttpPost]
        public IActionResult Post(Poliza poliza)
        {
            Response response = _polizaInteractor.InsertPoliza(poliza);
            return GetStatus(response.Status, response);
        }
    }
}
