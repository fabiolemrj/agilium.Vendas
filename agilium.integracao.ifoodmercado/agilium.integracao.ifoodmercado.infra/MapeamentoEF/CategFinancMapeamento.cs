using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class CategFinancMapeamento : IEntityTypeConfiguration<CategFinanc>
    {
        public void Configure(EntityTypeBuilder<CategFinanc> builder)
        {
            builder.ToTable("categ_financ");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("IDCATEG").HasColumnType("bigint").IsRequired();
            builder.Property(c => c.NMCATEG).HasColumnName("NMCATEG").HasColumnType("varchar(20)");
            builder.Property(c => c.STCATEG).HasColumnName("STCATEG").HasColumnType("int");

            //chaves estrangeiras
            builder
                .HasMany(categFinanc => categFinanc.ContaReceber)
                .WithOne(contaReceber => contaReceber.CategFinanc)
                .HasForeignKey(contaReceber => new { contaReceber.IDCATEG_FINANC })
                .HasPrincipalKey(categFinanc => new { categFinanc.Id })
                 .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasMany(categFinanc => categFinanc.ContaPagar)
                .WithOne(contaPagar => contaPagar.CategFinanc)
                .HasForeignKey(contaPagar => new { contaPagar.IDCATEG_FINANC })
                .HasPrincipalKey(categFinanc => new { categFinanc.Id })
                 .OnDelete(DeleteBehavior.Cascade);

            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Ativo);
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);
        }
    }
}
