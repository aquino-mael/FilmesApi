using FilmesApi.Models;
using FilmesApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace FilmesApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmesController : ControllerBase
    {
        private readonly FilmeService _filmeService;

        public FilmesController(FilmeService filmeService)
        {
            _filmeService = filmeService;
        }
        
        [HttpPost]
        public async Task<IActionResult> AddMovie([FromBody] Filme filme)
        {
            var result = await _filmeService.CreateFilmeAsync(filme);
            return CreatedAtAction(nameof(RecuperaFilme), new { Id = result.Id }, result);
        }
        
        [HttpGet]
        public async Task<IActionResult> ListarFilmes()
        {
            var filmes = await _filmeService.GetAsync();
            return Ok(filmes);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> RecuperaFilme(Guid id)
        {
            var filme = await _filmeService.GetAsync(id);

            if (filme is null)
            {
                return NotFound();
            }

            return Ok(filme);
        }
    }
}