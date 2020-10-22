using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class PlanoContaMapeamento : IEntityTypeConfiguration<PlanoConta>
    {
        public void Configure(EntityTypeBuilder<PlanoConta> builder)
        {
            builder.ToTable("planoconta");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("IDCONTA").HasColumnType("bigint").IsRequired();

             
             builder.Property(c => c.IDEMPRESA).HasColumnName("IDEMPRESA").HasColumnType("bigint");  
             builder.Property(c => c.IDCONTAPAI).HasColumnName("IDCONTAPAI").HasColumnType("bigint");  
             builder.Property(c => c.CDCONTA).HasColumnName("CDCONTA").HasColumnType("varchar(20)");  
             builder.Property(c => c.DSCONTA).HasColumnName("DSCONTA").HasColumnType("varchar(50)");   
             builder.Property(c => c.TPCONTA).HasColumnName("TPCONTA").HasColumnType("int");  
             builder.Property(c => c.STCONTA).HasColumnName("STCONTA").HasColumnType("int");

            //chave estrangeira

            builder
               .HasMany(planoconta => planoconta.PlanoContasFilho)
               .WithOne(planocontafilho => planocontafilho.PlanoContaPai)
               .HasForeignKey(planocontafilho => new { planocontafilho.IDCONTAPAI })
               .HasPrincipalKey(planoconta => new { planoconta.Id })
                   .OnDelete(DeleteBehavior.Cascade);

            builder
                 .HasMany(planoconta => planoconta.PlanoContaLancamento)
                 .WithOne(planocontalanc => planocontalanc.PlanoConta)
                 .HasForeignKey(planocontalanc => new { planocontalanc.IDCONTA })
                 .HasPrincipalKey(planoconta => new { planoconta.Id })
                     .OnDelete(DeleteBehavior.Cascade);

            builder
                 .HasMany(planoconta => planoconta.PlanoContaSaldo)
                 .WithOne(planocontasaldo => planocontasaldo.PlanoConta)
                 .HasForeignKey(planocontasaldo => new { planocontasaldo.IDCONTA })
                 .HasPrincipalKey(planoconta => new { planoconta.Id })
                     .OnDelete(DeleteBehavior.Cascade);

            builder
                 .HasMany(planoconta => planoconta.ContaReceber)
                 .WithOne(contaReceber => contaReceber.PlanoConta)
                 .HasForeignKey(contaReceber => new { contaReceber.IDCONTA })
                 .HasPrincipalKey(planoconta => new { planoconta.Id })
                     .OnDelete(DeleteBehavior.Cascade);


            builder
                 .HasMany(planoconta => planoconta.ContaPagar)
                 .WithOne(contaPagar => contaPagar.PlanoConta)
                 .HasForeignKey(contaPagar => new { contaPagar.IDCONTA })
                 .HasPrincipalKey(planoconta => new { planoconta.Id })
                     .OnDelete(DeleteBehavior.Cascade);

            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Ativo);
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);
        }
    }
}
