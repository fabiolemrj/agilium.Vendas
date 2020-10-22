using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class CompraFiscalMapeamento : IEntityTypeConfiguration<CompraFiscal>
    {
        public void Configure(EntityTypeBuilder<CompraFiscal> builder)
        {
            builder.ToTable("compra_fiscal");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("IDCOMPRAFISCAL").HasColumnType("bigint").IsRequired();

            builder.Property(c => c.IDCOMPRA).HasColumnName("IDCOMPRA").HasColumnType("bigint"); 
            builder.Property(c => c.STMANIFESTO).HasColumnName("STMANIFESTO").HasColumnType("int");  
            builder.Property(c => c.DSXML).HasColumnName("DSXML").HasColumnType("mediumtext");

            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Ativo);
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);
        }
    }
}
