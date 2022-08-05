using System;
using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models
{
    public class Filme
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Campo titulo é obrigatório.")]
        public string Title { get; set; }
        
        [StringLength(30, ErrorMessage = "O gênero não pode passar de 30 caracteres.")]
        public string Gender { get; set; }
        
        [Required(ErrorMessage = "Campo Diretor é obrigatório.")]
        public string Director { get; set; }
        
        [Range(1, 600, ErrorMessage = "A duração dever ter no mínimo 1 e no máximo 600 minutos.")]
        public int DurationInMinutes { get; set; }
    }
}