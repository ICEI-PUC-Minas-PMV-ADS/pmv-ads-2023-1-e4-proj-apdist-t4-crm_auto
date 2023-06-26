namespace CRMobil.Web.Models.Cliente
{
    public class ClienteViewModel : EnderecoBase
    {
        public string Id_Cliente { get; set; }
        public string Nome_Cliente { get; set; }
        public string Cnpj_Cpf { get; set; }
        public string Cnpj_Ou_Cpf { get; set; }
        public string Apelido { get; set; }
        public string Data_Nascimento { get; set; }
        public string Data_Cadastro { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email_Nf { get; set; }
        public string Excluido { get; set; }
        public virtual IEnumerable<ClienteVeiculo> ClienteVeiculos { get; set; }
    }
}
