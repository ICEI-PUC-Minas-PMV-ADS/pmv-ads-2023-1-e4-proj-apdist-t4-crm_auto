using CRMobil.Entities.Funcionarios;
using CRMobil.Entities.Veiculos;
using CRMobil.Interfaces;
using CRMobil.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CRMobil.Controllers
{
    public class VeiculoController : Controller
    {
        private readonly IVeiculosServices _veiculoService;

        public VeiculoController(IVeiculosServices veiculoService)
        {
            _veiculoService = veiculoService;
        }

        // GET: api/<ClienteController>
        [HttpGet]
        public async Task<List<Veiculos>> RecuperaFuncionarios()
        {
            var listaVeiculo = await _veiculoService.GetAsync();

            return listaVeiculo;
        }

        // GET api/<ClienteController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Veiculos>> RecuperaVeiculoPorId(string id)
        {
            var veiculo = await _veiculoService.GetAsync(id);

            if (veiculo is null)
            {
                return NotFound();
            }

            return veiculo;
        }

        [HttpGet("{placa}")]
        [AllowAnonymous]
        public async Task<ActionResult<Veiculos>> RecuperaFuncionarioPorPlaca(string placa)
        {
            var veiculo = await _veiculoService.GetCpfAsync(placa);

            if (veiculo is null)
            {
                return NotFound();
            }

            return veiculo;
        }

        // POST api/<ClienteController>
        [HttpPost]
        public async Task<IActionResult> SalvarFuncionario(Veiculos newFuncionario)
        {
            await _veiculoService.CreateAsync(newFuncionario);

            return CreatedAtAction(nameof(SalvarFuncionario), new { id = newFuncionario.Id_Funcionario }, newFuncionario);
        }

        // PUT api/<ClienteController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> AtualizaFuncionario(string id, Veiculos updateFuncionario)
        {
            var funcionario = await _veiculoService.GetAsync(id);

            if (funcionario is null)
            {
                return NotFound();
            }

            updateFuncionario.Id_Funcionario = funcionario.Id_Funcionario;

            await _veiculoService.UpdateAsync(id, updateFuncionario);

            return NoContent();
        }

        // DELETE api/<ClienteController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> ExcluiCliente(string id)
        {
            var funcionario = await _veiculoService.GetAsync(id);

            if (funcionario is null)
            {
                return NotFound();
            }

            await _veiculoService.RemoveAsync(id);

            return NoContent();
        }
    }
}
