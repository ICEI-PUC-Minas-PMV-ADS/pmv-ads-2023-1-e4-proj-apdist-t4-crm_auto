using CRMobil.Web.Application.AppService;
using CRMobil.Web.Application.Validation;
using CRMobil.Web.Domain.Entities;
using CRMobil.Web.Models.Cliente;
using CRMobil.Web.Models.Oficina;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
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
            OficinaViewModel oficina = new OficinaViewModel();

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(apiUrl))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    oficina = JsonConvert.DeserializeObject<OficinaViewModel>(apiResponse);
                }
            }
            return View(oficina);
        }



        [HttpGet]
        public async Task<IActionResult> RecuperaCliente(string cnpj)
        {
            OficinaViewModel oficina = new OficinaViewModel();

            using (var httpCliente = new HttpClient())
            {
                using (var response = await httpCliente.GetAsync(apiUrl + "/" + cnpj))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    oficina = JsonConvert.DeserializeObject<OficinaViewModel>(apiResponse);
                }
            }
            return View("FormOficina", oficina);
        }

        public ViewResult AdicionaCliente() => View();

        [HttpPost]
        public async Task<IActionResult> AdicionaCliente(OficinaViewModel oficina)
        {
            OficinaViewModel oficinaCadastrado = new OficinaViewModel();

            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(oficina), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PostAsync(apiUrl, content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    oficinaCadastrado = JsonConvert.DeserializeObject<OficinaViewModel>(apiResponse);
                }
            }
            return View(oficinaCadastrado);
        }

        public async Task<IActionResult> Salvar(OficinaViewModel oficina)
        {

            try
            {
                OficinaViewModel cadastroOficina = new OficinaViewModel();

                using (var httpClient = new HttpClient())
                {
                    StringContent content = new StringContent(JsonConvert.SerializeObject(oficina), Encoding.UTF8, "application/json");

                    if (oficina.Id_Oficina != null && oficina.Cnpj != null)
                    {
                        using (var response = await httpClient.PutAsync(apiUrl + "/" + oficina.Cnpj, content))
                        {
                            if (response.IsSuccessStatusCode)
                            {
                                var apiResponse = await response.Content.ReadAsStringAsync();

                                cadastroOficina = JsonConvert.DeserializeObject<OficinaViewModel>(apiResponse);
                            }
                            else
                            {
                                cadastroOficina = null;
                                ModelState.AddModelError(string.Empty, "Error no servidor. Contate o Administrador.");
                            }
                        }
                    }
                    else
                    {
                        using (var response = await httpClient.PostAsync(apiUrl, content))
                        {
                            if (response.IsSuccessStatusCode)
                            {
                                var apiResponse = await response.Content.ReadAsStringAsync();

                                cadastroOficina = JsonConvert.DeserializeObject<OficinaViewModel>(apiResponse);
                            }
                            else
                            {
                                cadastroOficina = null;
                                ModelState.AddModelError(string.Empty, "Error no servidor. Contate o Administrador.");
                            }

                        }
                    }
                }

                return View("Index", cadastroOficina);
            }
            catch
            {
                throw;
            }
        }
    }
}
