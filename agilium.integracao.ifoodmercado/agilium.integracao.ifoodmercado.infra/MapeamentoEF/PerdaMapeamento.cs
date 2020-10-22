using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class PerdaMapeamento : IEntityTypeConfiguration<Perda>
    {
        public void Configure(EntityTypeBuilder<Perda> builder)
        {
            builder.ToTable("perda");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("IDPERDA").HasColumnType("bigint").IsRequired();
             
            builder.Property(c => c.IDEMPRESA).HasColumnName("IDEMPRESA").HasColumnType("bigint");  
            builder.Property(c => c.IDESTOQUE).HasColumnName("IDESTOQUE").HasColumnType("bigint");  
            builder.Property(c => c.IDESTOQUEHST).HasColumnName("IDESTOQUEHST").HasColumnType("bigint");  
            builder.Property(c => c.IDPRODUTO).HasColumnName("IDPRODUTO").HasColumnType("bigint");  
            builder.Property(c => c.IDUSUARIO).HasColumnName("IDUSUARIO").HasColumnType("bigint");  
            builder.Property(c => c.CDPERDA).HasColumnName("CDPERDA").HasColumnType("varchar(6)");  
            builder.Property(c => c.DTHRPERDA).HasColumnName("DTHRPERDA").HasColumnType("datetime");  
            builder.Property(c => c.TPPERDA).HasColumnName("TPPERDA").HasColumnType("int");  
            builder.Property(c => c.TPMOV).HasColumnName("TPMOV").HasColumnType("int");  
            builder.Property(c => c.NUQTDPERDA).HasColumnName("NUQTDPERDA").HasColumnType("double");  
            builder.Property(c => c.VLCUSTOMEDIO).HasColumnName("VLCUSTOMEDIO").HasColumnType("double");  
            builder.Property(c => c.DSOBS).HasColumnName("DSOBS").HasColumnType("varchar(200)");

            //chaves estrangeiras
            builder
               .HasMany(perda => perda.InventarioItem)
               .WithOne(inventarioItem => inventarioItem.Perda)
               .HasForeignKey(inventarioItem => new { inventarioItem.IDPERDA })
               .HasPrincipalKey(perda => new { perda.Id })
               .OnDelete(DeleteBehavior.Cascade);

            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Ativo);
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);
        }
    }
}
