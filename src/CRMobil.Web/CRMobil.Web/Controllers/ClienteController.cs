using CRMobil.Web.Models.Cliente;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace CRMobil.Web.Controllers
{
    public class ClienteController : Controller
    {
        private readonly string apiUrl = " https://localhost:7165/api/Cliente";

        public async Task<IActionResult> Index()
        {
            List<Cliente> listaClintes = new List<Cliente>();

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(apiUrl))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    listaClintes = JsonConvert.DeserializeObject<List<Cliente>>(apiResponse);
                }
            }
            return View(listaClintes);
        }

        //public ViewResult RecuperaCliente() => View();

        [HttpGet]
        public async Task<IActionResult> RecuperaCliente(string cpf_cnpj)
        {
            Cliente cliente = new Cliente();

            using (var httpCliente = new HttpClient())
            {
                using (var response = await httpCliente.GetAsync(apiUrl + "/" + cpf_cnpj))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    cliente = JsonConvert.DeserializeObject<Cliente>(apiResponse);
                }
            }
            return View("FormCliente", cliente);
        }

        public ViewResult AdicionaCliente() => View();

        [HttpPost]
        public async Task<IActionResult> AdicionaCliente(Cliente cliente)
        {
            Cliente clienteCadastrado = new Cliente();

            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(cliente), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PostAsync(apiUrl, content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    clienteCadastrado = JsonConvert.DeserializeObject<Cliente>(apiResponse);
                }
            }
            return View(clienteCadastrado);
        }
    }
}
