using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos.Endereco
{
    public class UpdateEnderecoDto
    {
        [Required(ErrorMessage = "O campo Logradouro é obrigatório")]
        public string Logradouro { get; set; }
        [Required]
        [Range(1, 9999)]
        public int Numero { get; set; }
        [Required(ErrorMessage = "O campo Bairro é obrigatório")]
        public string Bairo { get; set; }
        }
}
