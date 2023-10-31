using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Config
{
    public class ProductoMaquinaConfig : IEntityTypeConfiguration<ProductoMaquina>
    {
        public void Configure(EntityTypeBuilder<ProductoMaquina> builder)
        {
            builder.HasKey(pm => new { pm.NumMaquina, pm.NombreProducto });

            builder.HasOne(pm => pm.Maquina)
                .WithMany(m => m.ProductosMaquinas)
                .HasForeignKey(pm => pm.NumMaquina);

            builder.HasOne(pm => pm.Producto)
                    .WithMany(p => p.ProductosMaquinas)
                    .HasForeignKey(pm => pm.NombreProducto);
        }
    }
}
