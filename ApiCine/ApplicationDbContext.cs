using ApiCine.Entidades;
using Microsoft.EntityFrameworkCore;

namespace ApiCine
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        { 

        }

        public DbSet<Genero> Generos => Set<Genero>();
    }
}
