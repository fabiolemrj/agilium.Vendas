using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class BombaMapeamento : IEntityTypeConfiguration<Bomba>
    {
        public void Configure(EntityTypeBuilder<Bomba> builder)
        {
            builder.ToTable("bomba");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("IDBOMBA").HasColumnType("bigint").IsRequired();
            builder.Property(c => c.IDEMPRESA).HasColumnName("IDEMPRESA").HasColumnType("bigint");

            builder.Property(c => c.CDBOMBA).HasColumnName("CDBOMBA").HasColumnType("varchar(6)");  
            builder.Property(c => c.NUCNPJFABR).HasColumnName("NUCNPJFABR").HasColumnType("varchar(20)");   
            builder.Property(c => c.NMFABR).HasColumnName("NMFABR").HasColumnType("varchar(50)");   
            builder.Property(c => c.DSMODELO).HasColumnName("DSMODELO").HasColumnType("varchar(50)");   
            builder.Property(c => c.DSSERIE).HasColumnName("DSSERIE").HasColumnType("varchar(30)");   
            builder.Property(c => c.STBOMBA).HasColumnName("STBOMBA").HasColumnType("int");

            //chaves estrangeiras
            builder
             .HasMany(bomba => bomba.Bicos)
             .WithOne(bico => bico.Bomba)
             .HasForeignKey(bico => new { bico.IDBOMBA })
             .HasPrincipalKey(bomba => new { bomba.Id })
                 .OnDelete(DeleteBehavior.Cascade);

            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Ativo);
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);
        }
    }
}
