using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class PlanoContaSaldoMapeamento : IEntityTypeConfiguration<PlanoContaSaldo>
    {
        public void Configure(EntityTypeBuilder<PlanoContaSaldo> builder)
        {
            builder.ToTable("planoconta_saldo");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("IDSALDO").HasColumnType("bigint").IsRequired();

            builder.Property(c => c.IDCONTA).HasColumnName("IDCONTA").HasColumnType("bigint");  
            builder.Property(c => c.DTHRATU).HasColumnName("DTHRATU").HasColumnType("datetime");  
            builder.Property(c => c.NUANOMESREF).HasColumnName("NUANOMESREF").HasColumnType("int");  
            builder.Property(c => c.VLSALDO).HasColumnName("VLSALDO").HasColumnType("double");

            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Ativo);
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);
        }
    }
}
