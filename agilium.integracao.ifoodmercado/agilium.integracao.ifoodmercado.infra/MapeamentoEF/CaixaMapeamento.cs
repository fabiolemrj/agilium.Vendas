using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class CaixaMapeamento : IEntityTypeConfiguration<Caixa>
    {
        public void Configure(EntityTypeBuilder<Caixa> builder)
        {
            builder.ToTable("caixa");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("IDCAIXA").HasColumnType("bigint").IsRequired();

            builder.Property(c => c.IDEMPRESA).HasColumnName("IDEMPRESA").HasColumnType("bigint");
            builder.Property(c => c.IDTURNO).HasColumnName("IDTURNO").HasColumnType("bigint");
            builder.Property(c => c.IDPDV).HasColumnName("IDPDV").HasColumnType("bigint");
            builder.Property(c => c.IDFUNC).HasColumnName("IDFUNC").HasColumnType("bigint");
            builder.Property(c => c.SQCAIXA).HasColumnName("SQCAIXA").HasColumnType("int");
            builder.Property(c => c.STCAIXA).HasColumnName("STCAIXA").HasColumnType("int");
            builder.Property(c => c.DTHRABT).HasColumnName("DTHRABT").HasColumnType("datetime");
            builder.Property(c => c.VLABT).HasColumnName("VLABT").HasColumnType("double");
            builder.Property(c => c.DTHRFECH).HasColumnName("DTHRFECH").HasColumnType("datetime");
            builder.Property(c => c.VLFECH).HasColumnName("VLFECH").HasColumnType("double");

            //chaves estrangeiras
            builder
                .HasMany(caixa => caixa.CaixaMoedas)
                .WithOne(moedas => moedas.Caixa)
                .HasForeignKey(moedas => new { moedas.IDCAIXA })
                .HasPrincipalKey(caixa => new { caixa.Id })
                 .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasMany(caixa => caixa.CaixaMovimentacao)
                .WithOne(mov => mov.Caixa)
                .HasForeignKey(mov => new { mov.IDCAIXA })
                .HasPrincipalKey(caixa => new { caixa.Id })
                 .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasMany(caixa => caixa.Venda)
                .WithOne(venda => venda.Caixa)
                .HasForeignKey(venda => new { venda.IDCAIXA })
                .HasPrincipalKey(caixa => new { caixa.Id })
                 .OnDelete(DeleteBehavior.Cascade);

            builder
                 .HasMany(caixa => caixa.VendaTemporaria)
                 .WithOne(vendaTemp => vendaTemp.Caixa)
                 .HasForeignKey(vendaTemp => new { vendaTemp.IDCAIXA })
                 .HasPrincipalKey(caixa => new { caixa.Id })
                  .OnDelete(DeleteBehavior.Cascade);

            builder
               .HasMany(caixa => caixa.Pedidos)
               .WithOne(pedido => pedido.Caixa)
               .HasForeignKey(pedido => new { pedido.IDCAIXA })
               .HasPrincipalKey(caixa => new { caixa.Id })
                .OnDelete(DeleteBehavior.Cascade);

            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Ativo);
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);
        }
    }
}
