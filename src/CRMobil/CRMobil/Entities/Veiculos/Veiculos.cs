using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace CRMobil.Entities.Veiculos
{
    public class Veiculos
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        [BsonElement("id_veiculo")]
        public string Id_Veiculo { get; set; }

        [BsonElement("id_modelo")]
        public string Id_Modelo { get; set; }
        
        [BsonElement("placa_veiculo")]
        public string Placa_Veiculo { get; set; }
        
        [BsonElement("motorizacao")]
        public string Motorizacao { get; set; }
        
        [BsonElement("ano_fabricacao")]
        public string Ano_Fabricacao { get; set; }
        
        [BsonElement("ano_modelo")]
        public string Ano_Modelo { get; set; }
        
        [BsonElement("renavan")]
        public string Renavan { get; set; }
        
        [BsonElement("cor")]
        public string Cor { get; set; }
        
        [BsonElement("quilometragem")]
        public string Quilometragem { get; set; }

    }
}
