using Microsoft.EntityFrameworkCore;
using relatorio.Models;
using relatorio.Models.EntityConfig;

namespace relatorio.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            :base(options)
        {
        }

        public DbSet<Publicador> Publicadores { get; set; }
        public DbSet<Grupo> Grupos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PublicadorConfig());
            modelBuilder.ApplyConfiguration(new GrupoConfig());
        }
    }
}