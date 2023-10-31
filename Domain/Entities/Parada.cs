using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Parada
    {
        public Guid NumParada { get; set; }
        public String? Causa {  get; set; }
        public bool EsExterna { get; set; }
        public TimeOnly HoraInicio { get; set; }
        public TimeOnly HoraFin { get; set; }
        public int Numprueba { get; set; }
        public String? Encargado { get; set; }
        public Prueba? Prueba { get; set; }
    }
}
