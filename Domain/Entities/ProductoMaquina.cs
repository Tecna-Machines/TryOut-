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
