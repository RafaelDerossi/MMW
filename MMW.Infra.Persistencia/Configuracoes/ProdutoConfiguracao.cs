using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMW.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace MMW.Infra.Persistencia.Configuracoes
{
    public class ProdutoConfiguracao : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(a => a.Id);
            builder.ToTable("Produtos");
            builder.Property(a => a.DataInclusao)
                .HasColumnName("DataInclusao")
                .IsRequired()
                .HasColumnType("DateTime")
                .HasDefaultValueSql("GetDate()");
            builder.Property(a => a.DataAlteracao)
                .HasColumnName("DataAlteracao")
                .IsRequired()
                .HasColumnType("DateTime")
                .HasDefaultValueSql("GetDate()");
        }
    }
}
