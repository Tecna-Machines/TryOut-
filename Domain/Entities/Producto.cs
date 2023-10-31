namespace Domain.Entities
{
    public class Producto
    {
        public String? NombreProducto { get; set; }
        public String? Marca { get; set; }
        public IList<ProductoMaquina>? ProductosMaquinas { get; set; }
        public IList<ProductoFormato>? ProductosFormatos { get; set; }
    }
}
