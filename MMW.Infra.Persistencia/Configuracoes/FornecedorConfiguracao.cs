using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMW.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace MMW.Infra.Persistencia.Configuracoes
{
    public class FornecedorConfiguracao : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.CNPJ)
                .IsRequired()
                .HasColumnType("varchar(14)");
            
        }

      
    }
}
