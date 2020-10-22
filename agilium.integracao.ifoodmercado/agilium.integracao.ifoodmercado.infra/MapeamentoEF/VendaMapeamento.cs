using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class VendaMapeamento : IEntityTypeConfiguration<Venda>
    {
        public void Configure(EntityTypeBuilder<Venda> builder)
        {
            builder.ToTable("venda");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("IDVENDA").HasColumnType("bigint").IsRequired();

            builder.Property(c => c.IDCAIXA).HasColumnName("IDCAIXA").HasColumnType("bigint");
            builder.Property(c => c.IDCLIENTE).HasColumnName("IDCLIENTE").HasColumnType("bigint");
            builder.Property(c => c.SQVENDA).HasColumnName("SQVENDA").HasColumnType("int");
            builder.Property(c => c.DTHRVENDA).HasColumnName("DTHRVENDA").HasColumnType("datetime");
            builder.Property(c => c.NUCPFCNPJ).HasColumnName("NUCPFCNPJ").HasColumnType("varchar(20)");
            builder.Property(c => c.VLVENDA).HasColumnName("VLVENDA").HasColumnType("double");
            builder.Property(c => c.VLACRES).HasColumnName("VLACRES").HasColumnType("double");
            builder.Property(c => c.VLDESC).HasColumnName("VLDESC").HasColumnType("double");
            builder.Property(c => c.VLTOTAL).HasColumnName("VLTOTAL").HasColumnType("double");
            builder.Property(c => c.STVENDA).HasColumnName("STVENDA").HasColumnType("int");
            builder.Property(c => c.DSINFCOMPL).HasColumnName("DSINFCOMPL").HasColumnType("varchar(500)");
            builder.Property(c => c.VLTOTIBPTFED).HasColumnName("VLTOTIBPTFED").HasColumnType("double");
            builder.Property(c => c.VLTOTIBPTEST).HasColumnName("VLTOTIBPTEST").HasColumnType("double");
            builder.Property(c => c.VLTOTIBPTMUN).HasColumnName("VLTOTIBPTMUN").HasColumnType("double");
            builder.Property(c => c.VLTOTIBPTIMP).HasColumnName("VLTOTIBPTIMP").HasColumnType("double");
            builder.Property(c => c.NUNF).HasColumnName("NUNF").HasColumnType("int");
            builder.Property(c => c.DSSERIE).HasColumnName("DSSERIE").HasColumnType("varchar(10)");
            builder.Property(c => c.TPDOC).HasColumnName("TPDOC").HasColumnType("int");
            builder.Property(c => c.STEMISSAO).HasColumnName("STEMISSAO").HasColumnType("int");
            builder.Property(c => c.DSCHAVEACESSO).HasColumnName("DSCHAVEACESSO").HasColumnType("varchar(50)");

            //chaves estrangeiras
            builder
                .HasMany(venda => venda.VendaItem)
                .WithOne(item => item.Venda)
                .HasForeignKey(item => new { item.Id })
                .HasPrincipalKey(venda => new { venda.Id })
                 .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasMany(venda => venda.VendaMoeda)
                .WithOne(moeda => moeda.Venda)
                .HasForeignKey(moeda => new { moeda.Id })
                .HasPrincipalKey(venda => new { venda.Id })
                 .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasMany(venda => venda.VendaCancelada)
                .WithOne(cancel => cancel.Venda)
                .HasForeignKey(cancel => new { cancel.Id })
                .HasPrincipalKey(venda => new { venda.Id })
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasMany(venda => venda.VendaEspelho)
                .WithOne(espelho => espelho.Venda)
                .HasForeignKey(espelho => new { espelho.Id })
                .HasPrincipalKey(venda => new { venda.Id })
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasMany(venda => venda.VendaFiscal)
                .WithOne(fiscal => fiscal.Venda)
                .HasForeignKey(fiscal => new { fiscal.Id })
                .HasPrincipalKey(venda => new { venda.Id })
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasMany(venda => venda.Pedidovenda)
                .WithOne(pedidoVenda => pedidoVenda.Venda)
                .HasForeignKey(pedidoVenda => new { pedidoVenda.Id })
                .HasPrincipalKey(venda => new { venda.Id })
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasMany(venda => venda.Devolucao)
                .WithOne(devolucao => devolucao.Venda)
                .HasForeignKey(devolucao => new { devolucao.Id })
                .HasPrincipalKey(venda => new { venda.Id })
                .OnDelete(DeleteBehavior.Cascade);

            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Ativo);
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);
        }
    }
}
