using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using senai_czbooks.Domains;
using senai_czbooks.Interfaces;
using senai_czbooks.Repositories;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace senai_czbooks.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private IUsuarioRepository _usuarioRepository { get; set; }

        public UsuarioController()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        [HttpPost("Login")]
        public IActionResult Login(Usuario login)
        {
            Usuario usuarioBuscado = _usuarioRepository.BuscarPorUsuarioSenha(login.Usuario, login.Senha);

            if (usuarioBuscado == null)
            {
                return NotFound("Usuario ou senha inválidos!");
            }

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Usuario, usuarioBuscado.Usuario),
                new Claim(JwtRegisteredClaimNames.Jti, usuarioBuscado.idUsuario.ToString()),
                // new Claim(ClaimTypes.Role, usuarioBuscado.permissao),
                new Claim("Claim personalizada", "Valor teste")
            };

            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("czbooks-chave-autenticacao"));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: "senai_czbooks.webApi",               // emissor do token
                audience: "senai_czbooks.webApi",             // destinatário do token
                claims: claims,                        // dados definidos acima (linha 59)
                expires: DateTime.Now.AddMinutes(30),  // tempo de expiração
                signingCredentials: creds
        };

        return Ok(new
            {
                token = new JwtSecurityTokenHandler().WriteToken(token)
            });
        }
    }
}
