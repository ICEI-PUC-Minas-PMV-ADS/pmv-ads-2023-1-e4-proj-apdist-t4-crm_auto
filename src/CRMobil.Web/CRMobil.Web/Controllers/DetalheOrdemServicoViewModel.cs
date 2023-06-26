namespace CRMobil.Web.Controllers
{
    public class DetalheOrdemServicoViewModel
    {
        public string id_ordem { get; set; }
        public string id_servico { get; set; }
        public string id_mec_responsavel { get; set; }
        public string quantidade { get; set; }
        public string tempo_previsto { get; set; }
        public string data_inicio_servico { get; set; }
        public string data_fim_servico { get; set; }
        public string aprovado { get; set; }
        public string valor_unitario { get; set; }
    }
}
