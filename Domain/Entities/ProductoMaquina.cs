using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ProductoMaquina
    {
        public String? NumMaquina { get; set; }
        public Maquina? Maquina { get; set; }
        public String? NombreProducto { get; set; }
        public Producto? Producto { get; set; }
    }
}
