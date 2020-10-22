using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class PlanoContaLancamentoMapeamento : IEntityTypeConfiguration<PlanoContaLancamento>
    {
        public void Configure(EntityTypeBuilder<PlanoContaLancamento> builder)
        {
            builder.ToTable("planoconta_lanc");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("IDLANC").HasColumnType("bigint").IsRequired();
             
            builder.Property(c => c.IDCONTA).HasColumnName("IDCONTA").HasColumnType("bigint");  
            builder.Property(c => c.DTCAD).HasColumnName("DTCAD").HasColumnType("datetime");  
            builder.Property(c => c.DTREF).HasColumnName("DTREF").HasColumnType("date");  
            builder.Property(c => c.NUANOMESREF).HasColumnName("NUANOMESREF").HasColumnType("int");  
            builder.Property(c => c.DSLANC).HasColumnName("DSLANC").HasColumnType("varchar(500)");  
            builder.Property(c => c.VLLANC).HasColumnName("VLLANC").HasColumnType("double");  
            builder.Property(c => c.TPLANC).HasColumnName("TPLANC").HasColumnType("int");  
            builder.Property(c => c.STLANC).HasColumnName("STLANC").HasColumnType("int");


            //chaves estrangeiras
            builder
             .HasMany(planoContaLanc => planoContaLanc.ContaPagar)
             .WithOne(contaPagar => contaPagar.PlanoContaLancamento)
             .HasForeignKey(contaPagar => new { contaPagar.IDCONTAPAI })
             .HasPrincipalKey(planoContaLanc => new { planoContaLanc.Id })
             .OnDelete(DeleteBehavior.Cascade);

            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Ativo);
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);
        }
    }
}
