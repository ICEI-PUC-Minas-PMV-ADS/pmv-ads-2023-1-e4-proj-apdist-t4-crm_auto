using CRMobil.Entities.Cliente;
using CRMobil.Entities.Usuarios;
using CRMobil.Interfaces;
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
        private readonly IClientesServices _clienteService;
        private readonly IUsuariosService _usuarioService;

        public ClienteController(IClientesServices clienteService, IUsuariosService usuarioService)
        {
            _clienteService = clienteService;
            _usuarioService = usuarioService;
        }

        // GET: api/<ClienteController>
        [HttpGet]
        public async Task<List<Clientes>> RecuperaClientes()
        {
            var listaCliente = await _clienteService.GetAsync();

            return listaCliente;
        }

        //[HttpGet("{cpf_cnpj}")]
        //public async Task<ActionResult<Clientes>> RecuperaClientePorCpfCnpj(string cpf_cnpj)
        //{
        //    var cliente = await _clienteService.GetCpfCnpjAsync(cpf_cnpj);
          
        //    if (cliente is null)
        //    {
        //        return NotFound();
        //    }

        //    return cliente;
        //}

        [HttpGet("{id}")]
        public async Task<ActionResult<Clientes>> RecuperaClientePorId(string id)
        {
            var cliente = await _clienteService.GetByIdAsync(id);
            
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

            var usuario = new Usuarios();

            String nomeCompleto = newCliente.Nome_Cliente;
            String[] split = nomeCompleto.Split(" ");
            String resultado = split[split.Length - 1];
            int cnt = split.Length - 1;

            for (int i = 0; i < cnt; i++)
            {
                usuario.Nome_Usuario = usuario.Nome_Usuario + split[i].Substring(0, 1);
            }

            usuario.Nome_Usuario = usuario.Nome_Usuario + resultado;
            usuario.Tipo_Usuario = "Cliente";
            usuario.Senha = newCliente.Cnpj_Cpf;

            await _usuarioService.CreateUser(usuario);

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
        [HttpDelete("{cpf}")]
        public async Task<ActionResult> ExcluiCliente(string cpf)
        {
            var cliente = await _clienteService.GetAsync(cpf);

            if (cliente is null)
            {
                return NotFound();
            }

            await _clienteService.RemoveAsync(cpf);

            return NoContent();
        }
    }
}
