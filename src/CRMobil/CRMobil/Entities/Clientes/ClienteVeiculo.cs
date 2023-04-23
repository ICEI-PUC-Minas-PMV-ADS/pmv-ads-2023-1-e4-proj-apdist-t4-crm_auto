using MongoDB.Bson.Serialization.Attributes;

namespace CRMobil.Entities.Clientes
{
    public class ClienteVeiculo
    {
        [BsonElement("id_cliente_veiculo")]
        public string IdClienteVeiculo { get; set; }
        public string Id_Cli_veiculo { get; set; }
        public string Id_Veiculo { get; set; }
        public string Veiculo_Atual { get; set; }
    }
}
