namespace Domain.Entities
{
    public class Formato
    {
        public string? DescripcionFormato { get; set; }
        public int Cantidad { get; set; }
        public String? Unidad { get; set; }
        public IList<ProductoFormato>? ProductosFormatos { get; set; }
        public ICollection<Prueba>? Pruebas { get; set; }
    }
}
