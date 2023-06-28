using CRMobil.Entities.Funcionarios;
using CRMobil.Entities.Veiculos;
using CRMobil.Interfaces;
using CRMobil.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CRMobil.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VeiculoController : ControllerBase
    {
        private readonly IVeiculosServices _veiculoService;

        public VeiculoController(IVeiculosServices veiculoService)
        {
            _veiculoService = veiculoService;
        }

        // GET: api/<VeiculoController>
        [HttpGet]
        public async Task<List<Veiculos>> RecuperaVeiculos()
        {
            var listaVeiculo = await _veiculoService.GetAsync();

            return listaVeiculo;
        }

        // GET api/<VeiculoController>/ABC0D12
        [HttpGet("{placa}")]
        [AllowAnonymous]
        public async Task<ActionResult<Veiculos>> RecuperaVeiculoPorPlaca(string placa)
        {
            var veiculo = await _veiculoService.GetPlacaAsync(placa);

            if (veiculo is null)
            {
                return NotFound();
            }

            return veiculo;
        }

        // POST api/<VeiculoController>
        [HttpPost]
        public async Task<IActionResult> SalvarVeiculo(Veiculos newVeiculo)
        {
            await _veiculoService.CreateAsync(newVeiculo);

            return CreatedAtAction(nameof(SalvarVeiculo), new { id = newVeiculo.Id_Veiculo }, newVeiculo);
        }

        // PUT api/<VeiculoController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> AtualizaVeiculo(string id, Veiculos updateVeiculo)
        {
            var veiculo = await _veiculoService.GetAsync(id);

            if (veiculo is null)
            {
                return NotFound();
            }

            updateVeiculo.Id_Veiculo = veiculo.Id_Veiculo;

            await _veiculoService.UpdateAsync(id, updateVeiculo);

            return NoContent();
        }

        // DELETE api/<VeiculoController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> ExcluiVeiculo(string id)
        {
            var veiculo = await _veiculoService.GetAsync(id);

            if (veiculo is null)
            {
                return NotFound();
            }

            await _veiculoService.RemoveAsync(id);

            return NoContent();
        }
    }
}
