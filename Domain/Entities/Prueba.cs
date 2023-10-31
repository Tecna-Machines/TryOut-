using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Prueba
    {
        public int Numprueba { get; set; }
        public String? Observacion { get; set; }
        public String? Encargado { get; set; }
        public int VelocidadTeoria { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin {  get; set; }
        public Resultado? Resultado { get; set; }
        public ICollection<Parada>? Paradas { get; set; }
        public string? DescripcionFormato { get; set; }
        public Formato? Formato { get; set; }
        public String? NumMaquina { get; set; }
        public Maquina? Maquina { get; set; }    

    }
}
