using Microsoft.EntityFrameworkCore;
using relatorio.Models;

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
    }
}