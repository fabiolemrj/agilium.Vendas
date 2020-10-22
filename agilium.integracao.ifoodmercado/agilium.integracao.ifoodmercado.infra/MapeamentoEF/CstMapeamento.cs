using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class CstMapeamento : IEntityTypeConfiguration<Cst>
    {
        public void Configure(EntityTypeBuilder<Cst> builder)
        {
            builder.ToTable("cst");
            builder.HasKey(c => c.CST);

            builder.Property(c => c.CST).HasColumnName("CST").HasColumnType("varchar(5)").IsRequired();
            builder.Property(c => c.DESCR).HasColumnName("DESCR").HasColumnType("varchar(255)");

            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Ativo);
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);
            builder.Ignore(c => c.Id);
        }
    }
}
