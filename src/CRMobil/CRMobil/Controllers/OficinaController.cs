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

        // GET: api/<OficinaController>
        [HttpGet]
        public async Task<Oficinas> RecuperaOficinas()
        {
            var result = await _services.GetAsync();


            return result;
        }

        // GET api/<OficinaController>/5
        [HttpGet("{cnpj}")]
        public async Task<ActionResult<Oficinas>> RecuperaOficinaPorCnpj(string cnpj)
        {
            var oficina = await _services.GetCnpjAsync(cnpj);

            if (oficina is null)
            {
                return NotFound();
            }

            return oficina;
        }

        // POST api/<OficinaController>
        [Route("~/SalvarOficina")]
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> SalvarOficina(Oficinas newOficina)
        {
            await _services.CreateAsync(newOficina);

            return CreatedAtAction(nameof(SalvarOficina), new { id = newOficina.Id_Oficina}, newOficina);
        }

        // PUT api/<OficinaController>/5
        [HttpPut("{id}")]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> AtualizaOficina(string id, [FromBody] Oficinas updateOficina)
        {
            var oficina = await _services.GetAsync(id);
            if (oficina is null) { return NotFound(); }
            await _services.UpdateAsync(updateOficina);
            return Ok();
        }

        // DELETE api/<OficinaController>/5
        [HttpDelete("{id}")]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> ExcluiOficina(string id)
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
