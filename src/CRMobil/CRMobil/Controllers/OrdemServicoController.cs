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

        // GET: api/<ClienteController>
        [HttpGet]
        public async Task<List<OrdemServico>> RecuperaOrdemServico()
        {
            var listaOrdemServico = await _ordemServicosService.GetAsync();

            return listaOrdemServico;
        }

        // GET api/<ClienteController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OrdemServico>> RecuperaOrdemServicoPorId(string id)
        {
            var ordemServico = await _ordemServicosService.GetAsync(id);

            if (ordemServico is null)
            {
                return NotFound();
            }

            return ordemServico;
        }

        //[HttpGet("{cpf_cnpj}")]
        //[AllowAnonymous]
        //public async Task<ActionResult<OrdemServico>> RecuperaOrdemServicoPorCpfCnpj(string cpf_cnpj)
        //{
        //    var ordemServico = await _ordemServicosService.GetCpfCnpjAsync(cpf_cnpj);

        //    if (ordemServico is null)
        //    {
        //        return NotFound();
        //    }

        //    return ordemServico;
        //}

        // POST api/<ClienteController>
        [HttpPost]
        public async Task<IActionResult> SalvarOrdemServico(OrdemServico newOrdemServico)
        {
            await _ordemServicosService.CreateAsync(newOrdemServico);

            return CreatedAtAction(nameof(SalvarOrdemServico), new { id = newOrdemServico.Id_Cliente }, newOrdemServico);
        }

        // PUT api/<ClienteController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> AtualizaOrdemServico(string id, OrdemServico updateOrdemServico)
        {
            var ordemServico = await _ordemServicosService.GetAsync(id);

            if (ordemServico is null)
            {
                return NotFound();
            }

            updateOrdemServico.Id_Cliente = ordemServico.Id_Cliente;

            await _ordemServicosService.UpdateAsync(id, updateOrdemServico);

            return NoContent();
        }

        // DELETE api/<ClienteController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> ExcluiOrdemServico(string id)
        {
            var cliente = await _ordemServicosService.GetAsync(id);

            if (cliente is null)
            {
                return NotFound();
            }

            await _ordemServicosService.RemoveAsync(id);

            return NoContent();
        }
    }
}
