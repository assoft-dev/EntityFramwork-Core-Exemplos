using ExemploData.Models;
using Microsoft.EntityFrameworkCore;

namespace ExemploData.Controllers.Helps
{
    public class ClientesContext: DbContext
    {
        private const string Conections = 
            "server=DESKTOP-OI9GD14; database=ClientesDB; user id = sa; password=junior";
        public ClientesContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Conections);
            }
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }

        // Tabelas
        public DbSet<ClientesModels> Clientes { get; set; }
    }
}
