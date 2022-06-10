using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos.Filme
{
    public class CreateFilmeDto
    {
        [Required(ErrorMessage = "O campo titulo é obrigatório")]
        public string Titulo { get; set; }
        [Required]
        [Range(1900, 2022)]
        public int Ano { get; set; }
        [Required(ErrorMessage = "O campo diretor é obrigatório")]
        public string Diretor { get; set; }
        [Required(ErrorMessage = "O campo genero é obrigatório")]
        [StringLength(30, ErrorMessage = "O campo genero deve ter no máximo 30 caracteres")]
        public string Genero { get; set; }
        [Range(1, 600, ErrorMessage = "A duraçao deve ser no minimo de 1 minuto e no maximo de 600 minutos")]
        public int Duracao { get; set; }
    }
}
