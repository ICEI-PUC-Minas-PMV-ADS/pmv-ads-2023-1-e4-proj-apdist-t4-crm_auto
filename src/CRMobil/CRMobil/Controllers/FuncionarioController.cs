using CRMobil.Entities.Cliente;
using CRMobil.Entities.Funcionarios;
using CRMobil.Interfaces;
using CRMobil.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CRMobil.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class FuncionarioController : ControllerBase
    {
        private readonly IFuncionariosServices _funcionarioService;

        public FuncionarioController(IFuncionariosServices funcionarioService)
        {
            _funcionarioService = funcionarioService;
        }

        // GET: api/<ClienteController>
        [HttpGet]
        public async Task<List<Funcionarios>> RecuperaFuncionarios()
        {
            var listaFuncionario = await _funcionarioService.GetAsync();

            return listaFuncionario;
        }

        // GET api/<ClienteController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Funcionarios>> RecuperaFuncionarioPorId(string id)
        {
            var funcionario = await _funcionarioService.GetAsync(id);

            if (funcionario is null)
            {
                return NotFound();
            }

            return funcionario;
        }

        [HttpGet("{cpf}")]
        [AllowAnonymous]
        public async Task<ActionResult<Funcionarios>> RecuperaFuncionarioPorCpf(string cpf)
        {
            var funcionario = await _funcionarioService.GetCpfAsync(cpf);

            if (funcionario is null)
            {
                return NotFound();
            }

            return funcionario;
        }

        // POST api/<ClienteController>
        [HttpPost]
        public async Task<IActionResult> SalvarFuncionario(Funcionarios newFuncionario)
        {
            await _funcionarioService.CreateAsync(newFuncionario);

            return CreatedAtAction(nameof(SalvarFuncionario), new { id = newFuncionario.Id_Funcionario }, newFuncionario);
        }

        // PUT api/<ClienteController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> AtualizaFuncionario(string id, Funcionarios updateFuncionario)
        {
            var funcionario = await _funcionarioService.GetAsync(id);

            if (funcionario is null)
            {
                return NotFound();
            }

            updateFuncionario.Id_Funcionario = funcionario.Id_Funcionario;

            await _funcionarioService.UpdateAsync(id, updateFuncionario);

            return NoContent();
        }

        // DELETE api/<ClienteController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> ExcluiCliente(string id)
        {
            var funcionario = await _funcionarioService.GetAsync(id);

            if (funcionario is null)
            {
                return NotFound();
            }

            await _funcionarioService.RemoveAsync(id);

            return NoContent();
        }
    }
}
