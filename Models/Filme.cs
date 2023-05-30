using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoFilmesApi.Models
{
    public class Filme
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Diretor { get; set; }

        public string Genero { get; set; }

        public int Duracao { get; set; }
    }
}
