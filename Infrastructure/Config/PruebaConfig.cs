using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Config
{
    public class PruebaConfig : IEntityTypeConfiguration<Prueba>
    {
        public void Configure(EntityTypeBuilder<Prueba> builder)
        {
            builder.HasKey(p => p.Numprueba);

            builder.Property(p => p.Numprueba)
                        .ValueGeneratedOnAdd();

            builder.HasOne(p => p.Resultado)
                    .WithOne(r => r.Prueba)
                    .HasForeignKey<Resultado>(r => r.Numprueba);
        }
    }
}
