using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace CRMobil.Entities.ServicosOficina
{
    public class ServicosOficina
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        [Display(Name = "id_servico")]
        public string Id_Servico { get; set; }

        [Display(Name = "descricao")]
        public string Descricao { get; set; }

        [Display(Name = "tempo_exec_servico")]
        public string Tempo_Exec_Servico { get; set; }

        [Display(Name = "custo_hora")]
        public string Custo_Hora { get; set; }
    }
}
