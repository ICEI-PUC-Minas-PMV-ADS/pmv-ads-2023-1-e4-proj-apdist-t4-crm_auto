using CRMobil.Web.Models.Cliente;
using CRMobil.Web.Models.Oficina;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using Newtonsoft.Json;
using System.Text;

namespace CRMobil.Web.Controllers
{
    public class OficinaController : Controller
    {

        private readonly string apiUrl = "https://localhost:7165/api/Oficina";
      
        public async Task<IActionResult> Index()
        {
            List<Oficina> oficina = new List<Oficina>();

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(apiUrl))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    oficina = JsonConvert.DeserializeObject<List<Oficina>>(apiResponse);
                }
            }
            return View(oficina);
        }

        [HttpGet]
        public async Task<IActionResult> RecuperaCliente(string cnpj)
        {
            Oficina oficina = new Oficina();

            using (var httpCliente = new HttpClient())
            {
                using (var response = await httpCliente.GetAsync(apiUrl + "/" + cnpj))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    oficina = JsonConvert.DeserializeObject<Oficina>(apiResponse);
                }
            }
            return View("FormOficina", oficina);
        }

        public ViewResult AdicionaCliente() => View();

        [HttpPost]
        public async Task<IActionResult> AdicionaCliente(Oficina oficina)
        {
            Oficina oficinaCadastrado = new Oficina();

            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(oficina), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PostAsync(apiUrl, content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    oficinaCadastrado = JsonConvert.DeserializeObject<Oficina>(apiResponse);
                }
            }
            return View(oficinaCadastrado);
        }
    }
}
