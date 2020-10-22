using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class VendaEspelhoMapeamento : IEntityTypeConfiguration<VendaEspelho>
    {
        public void Configure(EntityTypeBuilder<VendaEspelho> builder)
        {
            builder.ToTable("venda_espelho");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("IDESPELHO").HasColumnType("bigint").IsRequired();
                         
            builder.Property(c => c.IDVENDA).HasColumnName("IDVENDA").HasColumnType("bigint");  
            builder.Property(c => c.DSESPELHO).HasColumnName("DSESPELHO").HasColumnType("mediumtext");

            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Ativo);
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);
        }
    }
}
