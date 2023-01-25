using ApiCine.Entidades;
using Microsoft.EntityFrameworkCore;

namespace ApiCine
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        { 

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Genero>().Property(g=> g.Nombre).HasMaxLength(50);
        }
        public DbSet<Genero> Generos => Set<Genero>();
    }
}
