using MongoDB.Bson.Serialization.Attributes;

namespace CRMobil.Entities.Oficina
{
    public class Oficinas
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        [BsonElement("id_oficina")]
        public string Id_Oficina { get; set; }

        [BsonElement("cnpj")]
        public string Cnpj { get; set; }

        [BsonElement("nome_oficina")]
        public string Nome_Oficina { get; set; }

        [BsonElement("apelido")]
        public string Apelido { get; set; }

        [BsonElement("insc_estadual")]
        public string Insc_Estadual { get; set; }

        [BsonElement("insc_municipal")]
        public string Insc_Municipal { get; set; }

        [BsonElement("cep")]
        public string Cep { get; set; }

        [BsonElement("logradouro")]
        public string Logradouro { get; set; }

        [BsonElement("numero")]
        public string Numero { get; set; }

        [BsonElement("complemento")]
        public string Complemento { get; set; }

        [BsonElement("bairro")]
        public string Bairro { get; set; }

        [BsonElement("cidade")]
        public string Cidade { get; set; }

        [BsonElement("telefone1")]
        public string Telefone1 { get; set; }

        [BsonElement("telefone2")]
        public string Telefone2 { get; set; }

        [BsonElement("email")]
        public string Email { get; set; }

        [BsonElement("email_nf")]
        public string Email_nf { get; set; }

        [BsonElement("opcao_cadastro")]
        public string Opcao_Cadastro { get; set; }
    }
}
