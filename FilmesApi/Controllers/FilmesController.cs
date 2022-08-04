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
        private List<Filme> filmes = new List<Filme>();
        
        [HttpPost]
        public void AddMovie(Filme addMovieDto)
        {
            Console.WriteLine(addMovieDto.Title);
        }
    }
}