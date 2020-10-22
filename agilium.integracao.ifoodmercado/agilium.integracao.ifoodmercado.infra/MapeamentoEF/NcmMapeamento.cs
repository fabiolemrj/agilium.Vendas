using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class NcmMapeamento : IEntityTypeConfiguration<Ncm>
    {
        public void Configure(EntityTypeBuilder<Ncm> builder)
        {
            builder.ToTable("ncm");
            builder.HasKey(c => c.CDNCM);

            builder.Property(c => c.CDNCM).HasColumnName("CDNCM").HasColumnType("varchar(15)").IsRequired();
            builder.Property(c => c.DSDESCR).HasColumnName("DSDESCR").HasColumnType("varchar(300)");

            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Id);
            builder.Ignore(c => c.Ativo);
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);
        }
    }
}
