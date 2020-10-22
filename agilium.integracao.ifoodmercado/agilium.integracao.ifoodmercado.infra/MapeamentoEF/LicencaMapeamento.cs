using agilium.integracao.ifoodmercado.dominio.Entidades;
using agilium.integracao.ifoodmercado.dominio.Interfaces.Repositorios;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class LicencaMapeamento : IEntityTypeConfiguration<Licenca>
    {
        public void Configure(EntityTypeBuilder<Licenca> builder)
        {
            builder.ToTable("licenca");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("IDLICENCA").HasColumnType("bigint").IsRequired();

            builder.Property(c => c.IDEMPRESA).HasColumnName("IDEMPRESA").HasColumnType("bigint");
            builder.Property(c => c.K1).HasColumnName("K1").HasColumnType("varchar(50)");
            builder.Property(c => c.K2).HasColumnName("K2").HasColumnType("varchar(50)");
            builder.Property(c => c.K3).HasColumnName("K3").HasColumnType("varchar(50)");
            builder.Property(c => c.K4).HasColumnName("K4").HasColumnType("varchar(20)");
            builder.Property(c => c.K5).HasColumnName("K5").HasColumnType("varchar(20)");
            builder.Property(c => c.K6).HasColumnName("K6").HasColumnType("varchar(50)");
            builder.Property(c => c.K7).HasColumnName("K7").HasColumnType("varchar(30)");

            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Ativo);
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);
        }
    }
}
