using MongoDB.Bson;
using Polizas.Core.Entities;
using Polizas.Core.Interfaces.Repositories;
using Polizas.Core.Interfaces.UsesCases;

namespace Polizas.Core.UsesCases
{
    public class PolizaInteractor : IPolizaInteractor
    {
        private readonly IRepositoryWrapper _repositoryWrapper;

        public PolizaInteractor(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper ?? throw new ArgumentException(nameof(repositoryWrapper));
        }

        public Response GetPoliza(string query)
        {
            Func<Response> func = () =>
            {
                List<Poliza> polizas = new List<Poliza>();
                _repositoryWrapper.Poliza.FindByCondition(x => x.PlacaAutomotor.ToLower().Equals(query) ||
                    x.NumeroPoliza.ToLower().Equals(query)).Result.ForEach(x =>
                {
                polizas.Add(new Poliza()
                    {
                        CiudadResidenciaCliente = x.CiudadResidenciaCliente,
                        CoberturasCubiertasPoliza = x.CoberturasCubiertasPoliza,
                        CreatedAt = x.CreatedAt,
                        DireccionResidenciaCliente = x.DireccionResidenciaCliente,
                        FechaNacimientoCliente = x.FechaNacimientoCliente,
                        FechaTomaPoliza = x.FechaTomaPoliza,
                        IdentificacionCliente = x.IdentificacionCliente,
                        ModeloAutomotor = x.ModeloAutomotor,
                        NombreCliente = x.NombreCliente,
                        NombrePlanPoliza = x.NombrePlanPoliza,
                        NumeroPoliza = x.NumeroPoliza,
                        PlacaAutomotor = x.PlacaAutomotor,
                        ValorMaximoCubiertoPoliza = x.ValorMaximoCubiertoPoliza,
                        VehiculoTieneInspeccion = x.VehiculoTieneInspeccion,
                        _id = x._id
                    });
                });

                return polizas.Any() ?
                     new Response() { Status = 200, Message = "Ok", Payload = polizas} :
                     new Response() { Status = 204, Message = "No content", Payload = null };
            };

            return GetStatus(func);
        }
        

        public Response InsertPoliza(Poliza poliza)
        {
            Func<Response> func = () =>
            {
                _repositoryWrapper.Poliza.Create(poliza);
                return new Response() { Status = 201, Message = "Poliza creada con éxito", Payload = poliza };
            };

            return GetStatus(func);
        }

        public Response GetStatus(Func<Response> func)
        {
            try
            {
                return func();
            }
            catch (Exception e)
            {
                return new Response() { Status = 500, Message = e.Message, Payload = null };
            }
        }
    }
}
