using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class PontoVendaMapeamento : IEntityTypeConfiguration<PontoVenda>
    {
        public void Configure(EntityTypeBuilder<PontoVenda> builder)
        {
            builder.ToTable("pdv");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("IDPDV").HasColumnType("bigint").IsRequired();
            builder.Property(c => c.IDEMPRESA).HasColumnName("IDEMPRESA").HasColumnType("bigint");
            builder.Property(c => c.IDESTOQUE).HasColumnName("IDESTOQUE").HasColumnType("bigint");
            builder.Property(c => c.CDPDV).HasColumnName("CDPDV").HasColumnType("varchar(6)");
            builder.Property(c => c.DSPDV).HasColumnName("DSPDV").HasColumnType("varchar(50)");
            builder.Property(c => c.Ativo).HasColumnName("STPDV").HasColumnType("int");
            builder.Property(c => c.NMMAQUINA).HasColumnName("NMMAQUINA").HasColumnType("varchar(50)");
            builder.Property(c => c.DSCAMINHO_CERT).HasColumnName("DSCAMINHO_CERT").HasColumnType("varchar(255)");
            builder.Property(c => c.DSSENHA_CERT).HasColumnName("DSSENHA_CERT").HasColumnType("varchar(30)");

            //chaves estrangeiras
            builder
                .HasMany(pdv => pdv.Caixas)
                .WithOne(caixa => caixa.PontoVenda)
                .HasForeignKey(caixa => new { caixa.IDPDV })
                .HasPrincipalKey(pdv => new { pdv.Id })
                 .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasMany(pdv => pdv.Pedidos)
                .WithOne(pedido => pedido.PontoVenda)
                .HasForeignKey(pedido => new { pedido.IDPDV })
                .HasPrincipalKey(pdv => new { pdv.Id })
                 .OnDelete(DeleteBehavior.Cascade);


            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);
        }
    }
}
