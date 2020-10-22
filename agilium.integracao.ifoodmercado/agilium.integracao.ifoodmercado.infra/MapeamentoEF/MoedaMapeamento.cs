using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class MoedaMapeamento : IEntityTypeConfiguration<Moeda>
    {
        public void Configure(EntityTypeBuilder<Moeda> builder)
        {
            builder.ToTable("moeda");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("IDMOEDA").HasColumnType("bigint").IsRequired();
            builder.Property(c => c.IDEMPRESA).HasColumnName("IDEMPRESA").HasColumnType("bigint"); 
            builder.Property(c => c.CDMOEDA).HasColumnName("CDMOEDA").HasColumnType("varchar(6)");  
            builder.Property(c => c.DSMOEDA).HasColumnName("DSMOEDA").HasColumnType("varchar(50)");   
            builder.Property(c => c.STMOEDA).HasColumnName("STMOEDA").HasColumnType("int");  
            builder.Property(c => c.TPDOCFISCAL).HasColumnName("TPDOCFISCAL").HasColumnType("int");  
            builder.Property(c => c.TPMOEDA).HasColumnName("TPMOEDA").HasColumnType("int");  
            builder.Property(c => c.PCTAXA).HasColumnName("PCTAXA").HasColumnType("double");  
            builder.Property(c => c.STTROCO).HasColumnName("STTROCO").HasColumnType("int");  
            builder.Property(c => c.COR_BOTAO).HasColumnName("COR_BOTAO").HasColumnType("varchar(20)");  
            builder.Property(c => c.COR_FONTE).HasColumnName("COR_FONTE").HasColumnType("varchar(20)");   
            builder.Property(c => c.TECLA_ATALHO).HasColumnName("TECLA_ATALHO").HasColumnType("varchar(10)");

            //chaves estrangeiras
            builder
                .HasMany(moeda => moeda.CaixaMoedas)
                .WithOne(caixamoeda => caixamoeda.Moeda)
                .HasForeignKey(caixamoeda => new { caixamoeda.IDMOEDA })
                .HasPrincipalKey(moeda => new { moeda.Id })
                 .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasMany(moeda => moeda.VendaMoedas)
                .WithOne(venda => venda.Moeda)
                .HasForeignKey(venda => new { venda.IDMOEDA })
                .HasPrincipalKey(moeda => new { moeda.Id })
                 .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasMany(moeda => moeda.VendaTemporariaMoedas)
                .WithOne(vendaTemp => vendaTemp.Moeda)
                .HasForeignKey(vendaTemp => new { vendaTemp.IDMOEDA })
                .HasPrincipalKey(moeda => new { moeda.Id })
                 .OnDelete(DeleteBehavior.Cascade);

            builder
         .HasMany(moeda => moeda.PedidoPagamento)
         .WithOne(vendaTemp => vendaTemp.Moeda)
         .HasForeignKey(vendaTemp => new { vendaTemp.IDMOEDA })
         .HasPrincipalKey(moeda => new { moeda.Id })
          .OnDelete(DeleteBehavior.Cascade);


            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Ativo);
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);
        }
    }
}
