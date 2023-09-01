using Microsoft.AspNetCore.Mvc;
using Aula5.Model;

namespace Aula5.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class UsuarioController : ControllerBase
    {
        List<Usuario> usuarios = new List<Usuario>();

        [HttpGet("{id}")]
        public IActionResult GetUsuarioById(int id)
        {
            Usuario user = usuarios.FirstOrDefault(user=> user.Id == id);
            if(user == null)
            {
                return Ok(user);
            }
            return NotFound();
        }

        [HttpPost]

        public void AddUsuario([FromBody] Usuario user)
        {
            usuarios.Add(user);

        }

    }
}
