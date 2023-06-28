using CRMobil.Web.Models.Cliente;
using CRMobil.Web.Models.Oficina;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using Newtonsoft.Json;

namespace CRMobil.Web.Controllers
{
    public class OrdemServicoController : Controller
    {
        private readonly string apiUrl = "https://localhost:7165/api/OrdemServico";

        public async Task<IActionResult> Index()
        {
            List<OrdemServicoViewModel> listaOrdemServico = new List<OrdemServicoViewModel>();

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(apiUrl))
                {
                    string apiOSResponse = await response.Content.ReadAsStringAsync();
                    if (apiOSResponse != null)
                    {
                        listaOrdemServico = JsonConvert.DeserializeObject<List<OrdemServicoViewModel>>(apiOSResponse);
                        
                        ClienteViewModel cliente = new ClienteViewModel();
                        
                        foreach (var listaOS in listaOrdemServico)
                        { 
                            using (var httpCliente = new HttpClient())
                            {
                                using (var responseCliente = await httpCliente.GetAsync("https://localhost:7165/api/Cliente" + "/" + listaOS.Id_Cliente))
                                {
                                    string apiClienteResponse = await responseCliente.Content.ReadAsStringAsync();
                                    cliente = JsonConvert.DeserializeObject<ClienteViewModel>(apiClienteResponse);

                                    listaOS.NomeCliente = cliente.Nome_Cliente;
                                    foreach (var clienteOS in cliente.ClienteVeiculos)
                                    {
                                        if (clienteOS.Id_Veiculo == listaOS.Id_Veiculo)
                                        {
                                            listaOS.PlacaVeiculo = clienteOS.Placa_Veiculo;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return View(listaOrdemServico);
        }

        //public async Task<IActionResult> ListaCliente(string id)
        //{
        //    ClienteViewModel cliente = new ClienteViewModel();

        //    using (var httpCliente = new HttpClient())
        //    {
        //        string apiUrl = "https://localhost:7165/api/OrdemServico"
        //        using (var response = await httpCliente.GetAsync(apiUrl + "/" + id))
        //        {
        //            string apiResponse = await response.Content.ReadAsStringAsync();
        //            cliente = JsonConvert.DeserializeObject<ClienteViewModel>(apiResponse);
        //        }
        //    }
        //    return View("FormCliente", cliente);
        //}
    }
}