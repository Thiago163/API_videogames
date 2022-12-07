using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_videogames.DTO
{
    public class VideogameDTO
    {
        public int ID { get; set; }
        public string Titulo { get; set; }
        public string Plataforma { get; set; }
        public string Genero { get; set; }
        public string Premios { get; set; }
        public DateTime DataLancamento { get; set; }
    }
}
