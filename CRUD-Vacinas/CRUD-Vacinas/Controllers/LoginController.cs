using CRUD_Vacinas.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Vacinas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public async Task<ActionResult<dynamic>> Login([FromBody] Usuario model)
        {
            IList<Usuario> colecaoUsuarios = new List<Usuario>()
            {
                new Usuario() { Login = "usuario", Senha = "senha", Permissoes = new List<string> {"operador" } },
                new Usuario() { Login = "admin", Senha = "admin", Permissoes = new List<string> {"operador", "admin" } }
            };

            Usuario usuario = colecaoUsuarios.FirstOrDefault(u => u.Login == u.Login && u.Senha == model.Senha);

            if (usuario == null)
                return Unauthorized();

            // Gera o Token
            var token = GenerateToken(usuario);

            // Oculta a senha
            usuario.Senha = "";

            // Retorna os dados
            return new
            {
                Usuario = usuario,
                Token = token
            };
        }

        private string GenerateToken(Usuario usuario)
        {
            IList<Claim> claims = new List<Claim>();

            claims.Add(new Claim(ClaimTypes.Name, usuario.Login));

            foreach (var item in usuario.Permissoes)
            {
                claims.Add(new Claim(ClaimTypes.Role, item));
            }

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes("fedaf7d8863b48e197b9287d492b708e");
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
