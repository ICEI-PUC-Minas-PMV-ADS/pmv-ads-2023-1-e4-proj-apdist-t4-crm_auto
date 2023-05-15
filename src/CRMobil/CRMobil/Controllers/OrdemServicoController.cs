using CRMobil.Entities.OrdemServico;
using CRMobil.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CRMobil.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdemServicoController : Controller
    {
        private readonly IOrdemServicoServices _ordemServicosService;

        public OrdemServicoController(IOrdemServicoServices clienteService)
        {
            _ordemServicosService = clienteService;
        }

        // GET: api/<OrdemServicoController>
        [HttpGet]
        public async Task<List<OrdemServico>> RecuperaOrdemServico()
        {
            var listaOrdemServico = await _ordemServicosService.GetAsync();

            return listaOrdemServico;
        }

        // GET api/<OrdemServicoController>/5
        [HttpGet("{numeroOS}")]
        public async Task<ActionResult<OrdemServico>> RecuperaOrdemServicoPorNumero(string numeroOS)
        {
            var ordemServico = await _ordemServicosService.GetNumeroOSAsync(numeroOS);

            if (ordemServico is null)
            {
                return NotFound();
            }

            return ordemServico;
        }

        // POST api/<OrdemServicoController>
        [HttpPost]
        public async Task<IActionResult> SalvarOrdemServico(OrdemServico newOrdemServico)
        {
            await _ordemServicosService.CreateAsync(newOrdemServico);

            return CreatedAtAction(nameof(SalvarOrdemServico), new { id = newOrdemServico.Id_Cliente }, newOrdemServico);
        }

        // PUT api/<OrdemServicoController>/5
        [HttpPut("{numeroOS}")]
        public async Task<ActionResult> AtualizaOrdemServico(string numeroOS, OrdemServico updateOrdemServico)
        {
            var ordemServico = await _ordemServicosService.GetNumeroOSAsync(numeroOS);

            if (ordemServico is null)
            {
                return NotFound();
            }

            updateOrdemServico.Id_Cliente = ordemServico.Id_Cliente;

            await _ordemServicosService.UpdateAsync(numeroOS, updateOrdemServico);

            return NoContent();
        }

        // DELETE api/<OrdemServicoController>/5
        [HttpDelete("{numeroOS}")]
        public async Task<ActionResult> ExcluiOrdemServico(string numeroOS)
        {
            var cliente = await _ordemServicosService.GetNumeroOSAsync(numeroOS);

            if (cliente is null)
            {
                return NotFound();
            }

            await _ordemServicosService.RemoveAsync(numeroOS);

            return NoContent();
        }
    }
}
