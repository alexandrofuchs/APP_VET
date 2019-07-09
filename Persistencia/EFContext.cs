using Microsoft.EntityFrameworkCore;
using Modelo;

namespace Persistencia
{
    public class EFContext : DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }

        public DbSet<Veterinario> Veterinario { get; set; }

        public DbSet<Animal> Animal { get; set; }

        public DbSet<Consulta> Consulta { get; set; }

        public DbSet<Produto> Produto { get; set; }

        public DbSet<Exame> Exame { get; set; }

        public DbSet<Medicamento> Medicamento { get; set; }

        public DbSet<Agendamento> Agendamento { get; set; }

        public DbSet<ServicoClinico> ServicoClinico { get; set; }

        public DbSet<Atendimento> Atendimento { get; set; }

        public DbSet<Pagamento> Pagamento { get; set; }

        public DbSet<ItemProduto> ItemProduto { get; set; }

        public DbSet<ExameAnimal> ExameAnimal { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=DBVET;Trusted_Connection=True;");
        }
    }
}
