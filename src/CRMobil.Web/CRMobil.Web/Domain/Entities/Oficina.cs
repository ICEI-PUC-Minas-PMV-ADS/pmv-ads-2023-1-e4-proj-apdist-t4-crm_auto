using CRMobil.Web.Models;

namespace CRMobil.Web.Domain.Entities
{
    public class Oficina : EnderecoBase
    {
        public string Id_Oficina { get; set; }
        public string Cnpj { get; set; }
        public string Nome_Oficina { get; set; }
        public string Apelido { get; set; }
        public string Insc_Estadual { get; set; }
        public string Insc_Municipal { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }
        public string Email { get; set; }
        public string Email_nf { get; set; }
        public string Opcao_Cadastro { get; set; }
    }
}
