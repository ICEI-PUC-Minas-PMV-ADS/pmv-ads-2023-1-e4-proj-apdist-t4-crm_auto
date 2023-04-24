using CRMobil.Entities.ServicosOficina;
using CRMobil.Entities.Veiculos;
using CRMobil.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CRMobil.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ServicosOficinaController : ControllerBase
    {
        private readonly IServicosOficinaServices _servicosOficinaService;

        public ServicosOficinaController(IServicosOficinaServices servicosOficinaService)
        {
            _servicosOficinaService = servicosOficinaService;
        }

        // GET: api/<ServicosOficinaController>
        [HttpGet]
        public async Task<List<ServicosOficina>> RecuperaServicosOficina()
        {
            var listaServicos = await _servicosOficinaService.GetAsync();

            return listaServicos;
        }

        // GET api/<ServicosOficinaController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ServicosOficina>> RecuperaServicoOficinaPorId(string id)
        {
            var servicosOficina = await _servicosOficinaService.GetAsync(id);

            if (servicosOficina is null)
            {
                return NotFound();
            }

            return servicosOficina;
        }

        // GET api/<ServicosOficinaController>/RGX9A99
        [HttpGet("{placa}")]
        [AllowAnonymous]
        public async Task<ActionResult<ServicosOficina>> RecuperaFuncionarioPorPlaca(string descricaoServico)
        {
            var servicoOficina = await _servicosOficinaService.GetDescricaoAsync(descricaoServico);

            if (servicoOficina is null)
            {
                return NotFound();
            }

            return servicoOficina;
        }

        // POST api/<ServicosOficinaController>
        [HttpPost]
        public async Task<IActionResult> SalvaServicoOficina(ServicosOficina newServicoOficina)
        {
            await _servicosOficinaService.CreateAsync(newServicoOficina);

            return CreatedAtAction(nameof(SalvaServicoOficina), new { id = newServicoOficina }, newServicoOficina);
        }

        // PUT api/<ServicosOficinaController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> AtualizaServicoOficina(string id, ServicosOficina updateServicoOficina)
        {
            var servicoOficina = await _servicosOficinaService.GetAsync(id);

            if (servicoOficina is null)
            {
                return NotFound();
            }

            updateServicoOficina.Id_Servico = servicoOficina.Id_Servico;

            await _servicosOficinaService.UpdateAsync(id, updateServicoOficina);

            return NoContent();
        }

        // DELETE api/<ServicosOficinaController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> ExcluiServicoOficina(string id)
        {
            var veiculo = await _servicosOficinaService.GetAsync(id);

            if (veiculo is null)
            {
                return NotFound();
            }

            await _servicosOficinaService.RemoveAsync(id);

            return NoContent();
        }
    }
}
