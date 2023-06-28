using CRMobil.Web.Domain.Entities;
using CRMobil.Web.Models.Usuario;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace CRMobil.Web.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Autenticacao(LoginViewModel viewModel)
        {
            LoginViewModel loginViewModel = new LoginViewModel();

            HttpClient client = new HttpClient();

            StringContent content = new StringContent(JsonConvert.SerializeObject(viewModel), Encoding.UTF8, "application/json");

            string apiUrl = "https://localhost:7165/api/Usuario/login";

            using (var response = await client.PostAsync(apiUrl, content))
            {
                if (response != null)
                {
                    return View("/Views/Dashboard/Index.cshtml");
                }
                else
                {
                    loginViewModel = viewModel;
                }
            }

            ModelState.AddModelError(string.Empty, "Error no servidor. Contate o Administrador.");

            return View("Index", loginViewModel);
        }
    }
}
