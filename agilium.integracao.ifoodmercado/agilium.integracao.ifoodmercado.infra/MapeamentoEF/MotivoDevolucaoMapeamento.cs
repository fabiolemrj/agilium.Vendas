using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class MotivoDevolucaoMapeamento : IEntityTypeConfiguration<MotivoDevolucao>
    {
        public void Configure(EntityTypeBuilder<MotivoDevolucao> builder)
        {
            builder.ToTable("motivo_devolucao");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("IDMOTDEV").HasColumnType("bigint").IsRequired();
            builder.Property(c => c.IDEMPRESA).HasColumnName("IDEMPRESA").HasColumnType("bigint");

            builder.Property(c => c.DSMOTDEV).HasColumnName("DSMOTDEV").HasColumnType("varchar(50)");  
            builder.Property(c => c.STMOTDEV).HasColumnName("STMOTDEV").HasColumnType("int");

            //chaves estrangeiras
            builder
            .HasMany(motivoDevolucao => motivoDevolucao.Devolucao)
            .WithOne(devolucao => devolucao.MotivoDevolucao)
            .HasForeignKey(devolucao => new { devolucao.IDMOTDEV })
            .HasPrincipalKey(motivoDevolucao => new { motivoDevolucao.Id })
                .OnDelete(DeleteBehavior.Cascade);


            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Ativo);
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);
        }
    }
}
