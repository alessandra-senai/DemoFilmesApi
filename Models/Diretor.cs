using System.ComponentModel.DataAnnotations;

namespace DemoFilmesApi.Models
{
    public class Diretor
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Campo Obrigatório")]
        [MaxLength(200, ErrorMessage ="Este campo aceita até 200 caracteres")]
        [MinLength(3, ErrorMessage ="Favor digitar o nome do Diretor")]
        public string Nome { get; set; }


        [Required(ErrorMessage = "Campo Obrigatório")]
        [MaxLength(50, ErrorMessage = "Este campo aceita até 50 caracteres")]
        [MinLength(3, ErrorMessage = "Favor digitar o telefone do Diretor")]
        public string Telefone { get; set; }
    }
}
