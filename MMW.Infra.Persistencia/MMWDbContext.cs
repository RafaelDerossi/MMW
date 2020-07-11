using Microsoft.EntityFrameworkCore;
using MMW.Dominio.Entidades;
using MMW.Infra.Persistencia.Configuracoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMW.Infra.Persistencia
{
   public class MMWDbContext : DbContext
    {
        public MMWDbContext() { }

        public MMWDbContext(DbContextOptions<MMWDbContext> options) : base(options) { }

        
        public DbSet<Entrada> Entradas { get; set; }

        public DbSet<Estoque> Estoques { get; set; }

        public DbSet<Fornecedor> Fornecedores { get; set; }

        public DbSet<ItemEntrada> ItensEntrada { get; set; }

        public DbSet<Loja> Lojas { get; set; }

        public DbSet<Produto> Produtos { get; set; }
        


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                  .UseLazyLoadingProxies()
                .UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=dbMMW;Trusted_Connection = True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var prop in modelBuilder.Model.GetEntityTypes()
                .SelectMany(t => t.GetProperties())
                .Where(p => p.ClrType == typeof(string)))
            {
                if (prop.GetColumnType() == null)
                    prop.SetColumnType("varchar(255)");
            }

            modelBuilder.ApplyConfiguration(new ProdutoConfiguracao());
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries()
                .Where(e => e.Entity.GetType().GetProperty("DataInclusao") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataInclusao").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataInclusao").IsModified = false;
                }
            }

            foreach (var entry in ChangeTracker.Entries()
                .Where(e => e.Entity.GetType().GetProperty("DataAlteracao") != null))
            {
                entry.Property("DataAlteracao").CurrentValue = DateTime.Now;                
            }

            return base.SaveChanges();
        }
    }
}
