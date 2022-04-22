using BackEnd.Models;
using BackEnd.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BadRequest : ControllerBase
    {
        private IUsuario _usuarioService;

        public BadRequest(IUsuario usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet]
        //async Task é uma operação assincrona
        //ActionResult retornar uma resposta da api
        public async Task<ActionResult<IAsyncEnumerable<Usuario>>> GetUsuario()
        {
            var usuarios = await _usuarioService.GetUsuarios();
            return Ok(usuarios);

        }

        [HttpGet("{id}", Name="GetUsuario")]
        public async Task<ActionResult<Usuario>> GetUsuario(int id)
        {
            var usuario = await _usuarioService.GetUsuario(id);
            return Ok(usuario);

        }

        [HttpPost]
        public async Task<ActionResult> Create(Usuario usuario)
        {
                await _usuarioService.CreateUsuario(usuario);
                return CreatedAtRoute(nameof(GetUsuario), new { id = usuario.Id }, usuario);
          
        }

        [HttpPut("{id}")]
      
        public async Task<ActionResult> Update(int id, Usuario usuario)
        {
            if(usuario.Id == id)
            {
                await _usuarioService.UpdateUsuario(usuario);
                return Ok(usuario);
            }
            return BadRequest("Erro");

        }

        [HttpDelete("{id}")]

        public async Task<ActionResult> Delete(int id)
        {
            var usuario = await _usuarioService.GetUsuario(id);
           if(usuario != null)
            {
                await _usuarioService.DeleteUsuario(usuario);
                return Ok("Usuario excluido");
            }
            return BadRequest("Erro");

        }
       
    }
}
