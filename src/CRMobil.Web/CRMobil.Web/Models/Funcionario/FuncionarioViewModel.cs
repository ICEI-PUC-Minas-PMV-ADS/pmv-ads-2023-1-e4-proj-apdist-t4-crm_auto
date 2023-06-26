using CRMobil.Web.Domain.Entities;
using CRMobil.Web.Models.Usuario;

namespace CRMobil.Web.Models.Funcionario
{
    public class FuncionarioViewModel : EnderecoBase
    {
        public string Id_Funcionario { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public UsuarioViewModel Usuario { get; set; }
    }
}
