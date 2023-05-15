using MongoDB.Bson.Serialization.Attributes;

namespace CRMobil.Entities.OrdemServico
{
    public class AgendamentoServicos
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        [BsonElement("id_marca")]
        public string Id_Agendamento { get; set; }

        [BsonElement("id_cliente")]
        public string Id_Cliente { get; set; }

        [BsonElement("data_agendamento")]
        public string Data_Agendamento { get; set; }

        [BsonElement("id_cliente_veiculo")]
        public string Id_Cliente_Veiculo { get; set; }
    }
}
