using CRMobil.Entities.Cliente;
using CRMobil.Entities.Usuarios;
using CRMobil.Interfaces;
using CRMobil.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace CRMobil.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuariosService _userService;

        public UsuarioController(IUsuariosService userService)
        {
            _userService = userService;
        }

        //POST api/<UsuarioControllers>/5
        [AllowAnonymous]
        [HttpPost, Route("login")]
        public async Task<ActionResult<dynamic>> AuthenticateAsync([FromBody] Usuarios userModel)
        {
            userModel.Id_Usuario = "";
            userModel.Id_Funcionario = "";
            userModel.Tipo_Usuario = "";

            var user = await _userService.Login(userModel.Nome_Usuario, userModel.Senha);

            if (user == null)
            {
                return NotFound(new { message = "Usuário ou senha inválidos" });
            }

            var token = TokenService.GenerateToken(user);

            return new { username = user.Nome_Usuario, token = token };
        }

        [HttpPost]
        [Route("create")]
        public async Task<ActionResult<dynamic>> CreateUser([FromBody] Usuarios userModel)
        {
            try
            {
                string response = await _userService.CreateUser(userModel);
                return new ObjectResult(response) { StatusCode = StatusCodes.Status201Created };
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
