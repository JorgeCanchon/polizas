using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Runtime.Serialization;

namespace Polizas.Core.Entities
{
    [Serializable]
    [BsonIgnoreExtraElements]
    public class Poliza
    {
        [BsonId]
        [DataMember]
        [BsonRepresentation(BsonType.ObjectId)]
        [IgnoreDataMember]
        public ObjectId _id { get; set; }
        public string NumeroPoliza { get; set; }
        public string NombreCliente { get; set; }
        public string IdentificacionCliente { get; set; }
        public DateTime FechaNacimientoCliente { get; set; }
        public DateTime FechaTomaPoliza { get; set; }
        public string CoberturasCubiertasPoliza { get; set; }
        public long ValorMaximoCubiertoPoliza { get; set; }   
        public string NombrePlanPoliza { get; set; }
        public string CiudadResidenciaCliente { get; set; }
        public string DireccionResidenciaCliente { get; set; }
        public string PlacaAutomotor { get; set; }
        public string ModeloAutomotor { get; set; }
        public bool VehiculoTieneInspeccion { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
