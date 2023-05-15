using MongoDB.Bson.Serialization.Attributes;

namespace CRMobil.Entities.Veiculos
{
    public class ModeloVeiculos
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        [BsonElement("id_modelo")]
        public string Id_Modelo { get; set; }

        [BsonElement("id_modelo")]
        public string Id_Marca { get; set; }

        [BsonElement("nome_modelo")]
        public string Nome_Modelo { get; set; }
    }
}
