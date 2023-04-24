using MongoDB.Bson.Serialization.Attributes;

namespace CRMobil.Entities.Clientes
{
    public class ClienteVeiculo
    {
        [BsonElement("id_veiculo")]
        public string Id_Veiculo { get; set; }

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

        //[BsonElement("veiculo_atual")]
        //public string Veiculo_Atual { get; set; }
    }
}
