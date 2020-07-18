using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMW.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace MMW.Infra.Persistencia.Configuracoes
{
    public class EstoqueConfiguracao : IEntityTypeConfiguration<Estoque>
    {
        public void Configure(EntityTypeBuilder<Estoque> builder)
        {
            builder
                .HasIndex(a => new { a.LojaId, a.ProdutoId })
                .IsUnique();            
        }

      
    }
}
