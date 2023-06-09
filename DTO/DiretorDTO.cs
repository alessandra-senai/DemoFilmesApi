using System.ComponentModel.DataAnnotations;

namespace DemoFilmesApi.DTO
{
    public class DiretorDTO
    {
        [Required(ErrorMessage = "Campo Obrigatório")]
        [MaxLength(200, ErrorMessage = "Este campo aceita até 200 caracteres")]
        [MinLength(3, ErrorMessage = "Favor digitar o nome do Diretor")]
        [Display(Name ="Nome Diretor")]
        public string Nome { get; set; }


        [Required(ErrorMessage = "Campo Obrigatório")]
        [MaxLength(50, ErrorMessage = "Este campo aceita até 50 caracteres")]
        [MinLength(3, ErrorMessage = "Favor digitar o telefone do Diretor")]
        [Display(Name = "Telefone Diretor")]
        public string Telefone { get; set; }
    }
}
