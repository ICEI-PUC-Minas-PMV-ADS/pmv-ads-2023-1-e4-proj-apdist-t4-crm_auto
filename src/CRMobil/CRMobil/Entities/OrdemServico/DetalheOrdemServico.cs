using MongoDB.Bson.Serialization.Attributes;

namespace CRMobil.Entities.OrdemServico
{
    public class DetalheOrdemServico
    {
        [BsonElement("id_ordem")]
        public string Id_Ordem { get; set; }

        [BsonElement("id_servico")]
        public string Id_Servico { get; set; }

        [BsonElement("id_mec_responsavel")]
        public string Id_Mec_Responsavel { get; set; }

        [BsonElement("quantidade")]
        public string Quantidade { get; set; }

        [BsonElement("tempo_previsto")]
        public string Tempo_Previsto { get; set; }

        [BsonElement("data_inicio_servico")]
        public string Data_Inicio_Servico { get; set; }

        [BsonElement("data_fim_servico")]
        public string Data_Fim_Servico { get; set; }

        [BsonElement("aprovado")]
        public string Aprovado { get; set; }

        [BsonElement("valor_unitario")]
        public string Valor_Unitario { get; set; }
    }
}
