using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class VendaFiscalMapeamento : IEntityTypeConfiguration<VendaFiscal>
    {
        public void Configure(EntityTypeBuilder<VendaFiscal> builder)
        {
            builder.ToTable("venda_fiscal");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("IDVENDAFISCAL").HasColumnType("bigint").IsRequired();

            builder.Property(c => c.IDVENDA).HasColumnName("IDVENDA").HasColumnType("bigint");  
            builder.Property(c => c.TPDOC).HasColumnName("TPDOC").HasColumnType("int");  
            builder.Property(c => c.DSXML).HasColumnName("DSXML").HasColumnType("mediumtext");  
            builder.Property(c => c.STDOCFISCAL).HasColumnName("STDOCFISCAL").HasColumnType("int");  
            builder.Property(c => c.DTHREMISSAO).HasColumnName("DTHREMISSAO").HasColumnType("datetime");

            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Ativo);
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);
        }
    }
}
