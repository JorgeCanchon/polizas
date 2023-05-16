using Polizas.Core.Entities;

namespace Polizas.Core.Interfaces.UsesCases
{
    public interface IPolizaInteractor
    {
        Response GetPoliza(string query);
        Response InsertPoliza(Poliza poliza);
    }
}
