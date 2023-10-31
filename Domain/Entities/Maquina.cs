using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Maquina
    {
        public String? NumMaquina {  get; set; }
        public String? Nombre { get; set; }
        public String? Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public IList<ProductoMaquina>? ProductosMaquinas { get; set; }
        public ICollection<Prueba>? Pruebas { get; set; }
    }
}
