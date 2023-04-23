using CRMobil.Entities.Cliente;
using CRMobil.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.Hosting;
using MongoDB.Bson;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CRMobil.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly ClientesService _clienteService;

        public ClienteController(ClientesService clienteService)
        {
            _clienteService = clienteService;
        }

        // GET: api/<ClienteController>
        [HttpGet]
        public async Task<List<Clientes>> RecuperaClientes()
        {
            var listaCliente = await _clienteService.GetAsync();

            return listaCliente;
        }

        // GET api/<ClienteController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Clientes>> RecuperaClientePorId(string id)
        {
            var cliente = await _clienteService.GetAsync(id);

            if (cliente is null)
            {
                return NotFound();
            }

            return cliente;
        }

        [HttpGet("{cpf_cnpj}")]
        [AllowAnonymous]
        public async Task<ActionResult<Clientes>> RecuperaClientePorCpfCnpj(string cpf_cnpj)
        {
            var cliente = await _clienteService.GetCpfCnpjAsync(cpf_cnpj);

            if (cliente is null)
            {
                return NotFound();
            }

            return cliente;
        }

        // POST api/<ClienteController>
        [HttpPost]
        public async Task<IActionResult> SalvarCliente(Clientes newCliente)
        {
            await _clienteService.CreateAsync(newCliente);

            return CreatedAtAction(nameof(SalvarCliente), new { id = newCliente.Id_Cliente }, newCliente);
        }

        // PUT api/<ClienteController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> AtualizaCliente(string id, Clientes updateCliente)
        {
            var cliente = await _clienteService.GetAsync(id);

            if (cliente is null)
            {
                return NotFound();
            }
            
            updateCliente.Id_Cliente = cliente.Id_Cliente;

            await _clienteService.UpdateAsync(id, updateCliente);

            return NoContent();
        }

        // DELETE api/<ClienteController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> ExcluiCliente(string id)
        {
            var cliente = await _clienteService.GetAsync(id);

            if (cliente is null)
            {
                return NotFound();
            }

            await _clienteService.RemoveAsync(id);

            return NoContent();
        }
    }
}
