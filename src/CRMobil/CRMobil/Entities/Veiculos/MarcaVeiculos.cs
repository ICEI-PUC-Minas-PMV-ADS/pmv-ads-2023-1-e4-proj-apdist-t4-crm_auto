using MongoDB.Bson.Serialization.Attributes;

namespace CRMobil.Entities.Veiculos
{
    public class MarcaVeiculos
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        [BsonElement("id_marca")]
        public string Id_Marca { get; set; }

        [BsonElement("nome_marca")]
        public string Nome_Marca { get; set; }
    }
}
