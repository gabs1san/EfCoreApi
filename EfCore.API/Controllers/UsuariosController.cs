using eCommerce.Models;
using EfCore.API.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EfCore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuarioRepository _repository;

        public UsuariosController(IUsuarioRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var ListaUsuarios = _repository.Get();

            return Ok(ListaUsuarios);
        }

        [HttpGet("{Id}")]
        public IActionResult Get(int id)
        {
           var usuario =  _repository.Get(id);
            if (usuario == null)
                return NotFound("Não encontrado");

            return Ok(usuario);
        }

        [HttpPost]
        public IActionResult Add([FromBody] Usuario usuario)
        {

            _repository.Add(usuario);

            return Ok(usuario);
        }

        [HttpPut("{Id}")]
        public IActionResult Update([FromBody] Usuario usuario, int id)
        {
            _repository.Update(usuario);
            return Ok(usuario);
        }

        [HttpDelete("{Id}")]
        public IActionResult Delete(int id)
        {
            _repository.Delete(id);
            return Ok();
        }
    }
}
