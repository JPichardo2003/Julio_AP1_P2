using Julio_AP1_P2.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Julio_AP1_P2.Server.DAL
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<Entradas> Entradas { get; set; }
        public DbSet<Productos> Productos { get; set; }
        public DbSet<EntradasDetalle> EntradasDetalle { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Productos>().HasData(new List<Productos>()
        {
            new Productos(){ProductoId=1, Descripción="Maní", Existencia = 40, Tipo = 0},
            new Productos(){ProductoId=2, Descripción="Pistachos", Existencia = 600, Tipo = 0},
            new Productos(){ProductoId=3, Descripción="Pasas", Existencia = 500, Tipo = 0},
            new Productos(){ProductoId=4, Descripción="Ciruelas", Existencia = 700, Tipo = 0},
            new Productos(){ProductoId=5, Descripción="Mixto MPP 0.5lb", Existencia = 0, Tipo = 1},
            new Productos(){ProductoId=6, Descripción="Mixto MPC 0.5lb", Existencia = 0, Tipo = 1},
            new Productos(){ProductoId=7, Descripción="Mixto MPP 0.2lb", Existencia = 0, Tipo = 1}
        });
        }
    }
}
