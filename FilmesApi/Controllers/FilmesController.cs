using FilmesApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmesController : ControllerBase
    {
        private static List<Filme> filmes = new List<Filme>();
        
        [HttpPost]
        public IActionResult AddMovie([FromBody] Filme filme)
        {
            filme.Id = Guid.NewGuid();
            filmes.Add(filme);
            return CreatedAtAction(nameof(RecuperaFilme), new { Id = filme.Id }, filme);
        }
        
        [HttpGet]
        public IActionResult ListarFilmes()
        {
            return Ok(filmes);
        }

        [HttpGet("{Id}")]
        public IActionResult RecuperaFilme(Guid Id)
        {
            var filme = filmes.FirstOrDefault(f => f.Id.Equals(Id));

            if (filme == null)
            {
                return NotFound();
            }

            return Ok(filme);
        }
    }
}