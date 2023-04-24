using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace CRMobil.Entities.OrdemServico
{
    public class OrdemServico
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        [Display(Name = "id_ordem_servico")]
        public string Id_Ordem_Servico { get; set; }

        [BsonElement("id_cliente")]
        public string Id_Cliente { get; set; }

        [BsonElement("id_veiculo")]
        public string Id_Veiculo { get; set; }

        [BsonElement("data_ordem")]
        public string Data_Ordem { get; set; }

        [BsonElement("telefone_contato")]
        public string Telefone_Contato { get; set; }

        [BsonElement("email_contato")]
        public string Email_Contato { get; set; }

        [BsonElement("id_oficina")]
        public string Id_Oficina { get; set; }

        [BsonElement("id_agendamento")]
        public string Id_Agendamento { get; set; }

        [BsonElement("id_usuario_cad")]
        public string Id_Usuario_Cad { get; set; }

        public IEnumerable<DetalheOrdemServico> DetalheOrdemServico { get; set; }
    }
}
