using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class TurnoMapeamento : IEntityTypeConfiguration<Turno>
    {
        public void Configure(EntityTypeBuilder<Turno> builder)
        {
            builder.ToTable("turno");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("IDTURNO").HasColumnType("bigint").IsRequired();

            builder.Property(c => c.IDEMPRESA).HasColumnName("IDEMPRESA").HasColumnType("bigint");  
            builder.Property(c => c.IDUSUARIOINI).HasColumnName("IDUSUARIOINI").HasColumnType("bigint");  
            builder.Property(c => c.IDUSUARIOFIM).HasColumnName("IDUSUARIOFIM").HasColumnType("bigint");  
            builder.Property(c => c.DTTURNO).HasColumnName("DTTURNO").HasColumnType("date");  
            builder.Property(c => c.NUTURNO).HasColumnName("NUTURNO").HasColumnType("int");  
            builder.Property(c => c.DTHRINI).HasColumnName("DTHRINI").HasColumnType("datetime");  
            builder.Property(c => c.DTHRFIM).HasColumnName("DTHRFIM").HasColumnType("datetime");  
            builder.Property(c => c.DSOBS).HasColumnName("DSOBS").HasColumnType("text");

            //chaves estrangeiras
            builder
             .HasMany(turno => turno.Compra)
             .WithOne(compra => compra.Turno)
             .HasForeignKey(compra => new { compra.IDTURNO })
             .HasPrincipalKey(turno => new { turno.Id })
             .OnDelete(DeleteBehavior.Cascade);

            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Ativo);
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);
        }
    }
}
