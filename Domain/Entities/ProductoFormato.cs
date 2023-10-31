using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ProductoFormato
    {
        public String? NombreProducto { get; set; }
        public Producto? Producto { get; set; }
        public string? DescripcionFormato { get; set; }
        public Formato? Formato { get; set; }  
    }
}
