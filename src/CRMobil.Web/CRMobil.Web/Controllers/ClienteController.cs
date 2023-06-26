using CRMobil.Web.Models.Cliente;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace CRMobil.Web.Controllers
{
    public class ClienteController : Controller
    {
        private readonly string apiUrl = "https://localhost:7165/api/Cliente";

        public async Task<IActionResult> Index()
        {
            List<ClienteViewModel> listaClintes = new List<ClienteViewModel>();

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(apiUrl))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    listaClintes = JsonConvert.DeserializeObject<List<ClienteViewModel>>(apiResponse);
                }
            }
            return View(listaClintes);
        }

        [HttpGet]
        public async Task<IActionResult> RecuperaCliente(string id)
        {
            ClienteViewModel cliente = new ClienteViewModel();

            using (var httpCliente = new HttpClient())
            {
                using (var response = await httpCliente.GetAsync(apiUrl + "/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    cliente = JsonConvert.DeserializeObject<ClienteViewModel>(apiResponse);
                }
            }
            return View("FormCliente", cliente);
        }

        [HttpGet]
        public async Task<IActionResult> ListaCliente(ClienteViewModel viewModel)
        {
            ClienteViewModel cliente = new ClienteViewModel();

            using (var httpCliente = new HttpClient())
            {
                using (var response = await httpCliente.GetAsync(apiUrl + "/" + viewModel.Cnpj_Cpf))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    cliente = JsonConvert.DeserializeObject<ClienteViewModel>(apiResponse);
                }
            }
            return View("FormCliente", cliente);
        }

        public ViewResult AdicionaCliente() => View();

        [HttpPost]
        public async Task<IActionResult> AdicionaCliente(ClienteViewModel cliente)
        {
            ClienteViewModel clienteCadastrado = new ClienteViewModel();

            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(cliente), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PostAsync(apiUrl, content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    clienteCadastrado = JsonConvert.DeserializeObject<ClienteViewModel>(apiResponse);
                }
            }
            return View(clienteCadastrado);
        }
    }
}
