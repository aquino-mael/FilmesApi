using System;
using System.Collections.Generic;
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
        public void AddMovie([FromBody] Filme filme)
        {
            filme.Id = Guid.NewGuid();
            filmes.Add(filme);
        }
        
        [HttpGet]
        public IEnumerable<Filme> ListarFilmes()
        {
            return filmes;
        }
    }
}