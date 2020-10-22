using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class CfopMapeamento : IEntityTypeConfiguration<Cfop>
    {
        public void Configure(EntityTypeBuilder<Cfop> builder)
        {
            builder.ToTable("cfop");
            builder.HasKey(c => c.CDCFOP);

            builder.Property(c => c.CDCFOP).HasColumnName("CDCFOP").HasColumnType("int").IsRequired();
            builder.Property(c => c.DSCFOP).HasColumnName("DSCFOP").HasColumnType("varchar(400)");
            builder.Property(c => c.TPCFOP).HasColumnName("TPCFOP").HasColumnType("varchar(1)");

            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Ativo);
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);
            builder.Ignore(c => c.Id);
        }
    }
}
