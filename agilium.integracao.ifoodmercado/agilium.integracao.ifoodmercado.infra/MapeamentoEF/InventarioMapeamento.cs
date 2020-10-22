using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class InventarioMapeamento : IEntityTypeConfiguration<Inventario>
    {
        public void Configure(EntityTypeBuilder<Inventario> builder)
        {
            builder.ToTable("inventario");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("IDINVENT").HasColumnType("bigint").IsRequired();

            builder.Property(c => c.IDEMPRESA).HasColumnName("IDEMPRESA").HasColumnType("bigint");  
            builder.Property(c => c.IDESTOQUE).HasColumnName("IDESTOQUE").HasColumnType("bigint");  
            builder.Property(c => c.CDINVENT).HasColumnName("CDINVENT").HasColumnType("varchar(6)");  
            builder.Property(c => c.DSINVENT).HasColumnName("DSINVENT").HasColumnType("varchar(50)");   
            builder.Property(c => c.DTINVENT).HasColumnName("DTINVENT").HasColumnType("date");  
            builder.Property(c => c.STINVENT).HasColumnName("STINVENT").HasColumnType("int");  
            builder.Property(c => c.DSOBS).HasColumnName("DSOBS").HasColumnType("varchar(500)");  
            builder.Property(c => c.TPANALISE).HasColumnName("TPANALISE").HasColumnType("int");

            //chaves estrangeiras
            builder
               .HasMany(inventario => inventario.InventarioItem)
               .WithOne(inventarioItem => inventarioItem.Inventario)
               .HasForeignKey(inventarioItem => new { inventarioItem.IDINVENT })
               .HasPrincipalKey(inventario => new { inventario.Id })
               .OnDelete(DeleteBehavior.Cascade);

            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Ativo);
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);

        }
    }
}
