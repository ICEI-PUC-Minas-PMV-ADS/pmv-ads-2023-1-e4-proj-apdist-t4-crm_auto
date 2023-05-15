using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace CRMobil.Entities.Funcionarios
{
    public class Funcionarios
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        [Display(Name = "id_funcionario")]
        public string Id_Funcionario { get; set; }

        [BsonElement("cpf")]
        public string Cpf { get; set; }

        [BsonElement("nome")]
        public string Nome { get; set; }

        [BsonElement("funcao")]
        public string Funcao { get; set; }

        [BsonElement("id_oficina")]
        public string Id_Oficina { get; set; }

    }
}
