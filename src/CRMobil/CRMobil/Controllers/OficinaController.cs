using CRMobil.Entities.Cliente;
using CRMobil.Entities.Oficina;
using CRMobil.Interfaces;
using CRMobil.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRMobil.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class OficinaController : Controller
    {
        private readonly IOficinasServices _services;

        public OficinaController(IOficinasServices services)
        {
            _services = services;
        }

        // GET: api/<OficinasController>
        [HttpGet]
        public async Task<List<Oficinas>> RecuperaOficinas()
        {
            var result = await _services.GetAsync();

            return result;
        }

        // GET api/<OficinasController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Oficinas>> RecuperaOficinaPorId(string id)
        {
            var oficina = await _services.GetAsync(id);

            if (oficina is null)
            {
                return NotFound();
            }

            return oficina;
        }

        // GET api/<OficinasController>/5
        [HttpGet("{cnpj}")]
        public async Task<ActionResult<Oficinas>> RecuperaOficinaPorCnpj(string cpf_cnpj)
        {
            var oficina = await _services.GetCnpjAsync(cpf_cnpj);

            if (oficina is null)
            {
                return NotFound();
            }

            return oficina;
        }

        // POST api/<OficinasController>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SalvarOficina(Oficinas newOficina)
        {
            await _services.CreateAsync(newOficina);

            return CreatedAtAction(nameof(SalvarOficina), new { id = newOficina.Id_Oficina}, newOficina);
        }

        // PUT api/<OficinasController>/5
        [HttpPut("{id}")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AtualizaOficina(string id, Oficinas updateOficina)
        {
            var oficina = await _services.GetAsync(id);

            if (oficina is null)
            {
                return NotFound();
            }

            updateOficina.Id_Oficina = oficina.Id_Oficina;

            await _services.UpdateAsync(id, updateOficina);

            return NoContent();
        }

        // DELETE api/<OficinasController>/5
        [HttpDelete("{id}")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ExcluiOficina(string id)
        {
            var oficina = await _services.GetAsync(id);

            if (oficina is null)
            {
                return NotFound();
            }

            await _services.RemoveAsync(id);

            return NoContent();
        }
    }
}
