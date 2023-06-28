using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace CRMobil.Web.Models.Usuario
{
    public class LoginViewModel
    {
        public string Nome_Usuario { get; set; }

        public string Senha { get; set; }
    }
}
