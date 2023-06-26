using CRMobil.Web.Controllers;
using CRMobil.Web.Models.Cliente;
using System.ComponentModel.DataAnnotations;

namespace CRMobil.Web.Models.Oficina
{
    public class OrdemServicoViewModel
    {
        public string Id { get; set; }
        public string Numero_Ordem_Servico { get; set; }
        public string Id_Cliente { get; set; }
        public string Id_Veiculo { get; set; }
        public string Data_Ordem { get; set; }
        public string Telefone_Contato { get; set; }
        public string Email_Contato { get; set; }
        public string Id_Oficina { get; set; }
        public string Id_Agendamento { get; set; }
        public string Id_Usuario_Cad { get; set; }
        public IEnumerable<DetalheOrdemServicoViewModel> ListaDetaheOS { get; set;}

        public string? NomeCliente { get; set; }
        public string? PlacaVeiculo { get; set; }
    }
}
