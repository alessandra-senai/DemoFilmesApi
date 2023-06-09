using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DemoFilmesApi.Models
{
    public class FilmeDiretor
    {
        [Key]
        public int Id { get; set; }


        [ForeignKey("Filme")]
        public int IdFilme { get; set; }

        [ForeignKey("Diretores")]
        public int IdDiretor { get; set; }


        public Diretor Diretores { get; set; }

        public Filme Filme { get; set; }
    }
}
