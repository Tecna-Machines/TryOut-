using Domain.Entities;
using Infrastructure.Config;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence
{
    public class TryOutContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            string dbPath = Path.Combine(Directory.GetCurrentDirectory(), "Db", "TryOut.db");

            dbPath = "D:\\TryOut\\Infrastructure\\Db\\TryOut.db";
            options.UseSqlite($"Data Source={dbPath}");
        }

        public TryOutContext(DbContextOptions<TryOutContext> options) : base(options)
        {
        }


        public DbSet<Formato> Formatos { get; set; }
        public DbSet<Maquina> Maquinas { get; set; }
        public DbSet<Parada> Paradas { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<ProductoFormato> ProductosFormato { get; set; }
        public DbSet<ProductoMaquina> ProductoSMaquinas { get; set; }
        public DbSet<Prueba> Pruebas { get; set; }
        public DbSet<Resultado> Resultados { get; set; }

        //configracion
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FormatoConfig());
            modelBuilder.ApplyConfiguration(new MaquinaConfig());
            modelBuilder.ApplyConfiguration(new ParadaConfig());
            modelBuilder.ApplyConfiguration(new ProductoConfig());
            modelBuilder.ApplyConfiguration(new ProductoFormatoConfig());
            modelBuilder.ApplyConfiguration(new ProductoMaquinaConfig());
            modelBuilder.ApplyConfiguration(new PruebaConfig());
            modelBuilder.ApplyConfiguration(new ResultadoConfig());
        }
    }
}
