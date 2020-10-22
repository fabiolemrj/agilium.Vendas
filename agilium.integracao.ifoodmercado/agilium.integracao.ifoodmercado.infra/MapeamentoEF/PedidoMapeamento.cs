using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class PedidoMapeamento : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.ToTable("pedido");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("IDPEDIDO").HasColumnType("bigint").IsRequired();

            builder.Property(c => c.IDEMPRESA).HasColumnName("IDEMPRESA").HasColumnType("bigint");  
            builder.Property(c => c.IDFUNC).HasColumnName("IDFUNC").HasColumnType("bigint");  
            builder.Property(c => c.IDCLIENTE).HasColumnName("IDCLIENTE").HasColumnType("bigint");
            builder.Property(c => c.IDFUNC).HasColumnName("IDFUNC").HasColumnType("bigint");
            builder.Property(c => c.IDENDERECO).HasColumnName("IDENDERECO").HasColumnType("bigint");  
            builder.Property(c => c.IDCAIXA).HasColumnName("IDCAIXA").HasColumnType("bigint");  
            builder.Property(c => c.IDPDV).HasColumnName("IDPDV").HasColumnType("bigint");  
            builder.Property(c => c.CDPEDIDO).HasColumnName("CDPEDIDO").HasColumnType("varchar(6)");  
            builder.Property(c => c.DTPEDIDO).HasColumnName("DTPEDIDO").HasColumnType("datetime");  
            builder.Property(c => c.STPEDIDO).HasColumnName("STPEDIDO").HasColumnType("int");  
            builder.Property(c => c.VLPEDIDO).HasColumnName("VLPEDIDO").HasColumnType("double");  
            builder.Property(c => c.VLACRES).HasColumnName("VLACRES").HasColumnType("double");  
            builder.Property(c => c.VLDESC).HasColumnName("VLDESC").HasColumnType("double");  
            builder.Property(c => c.VLOUTROS).HasColumnName("VLOUTROS").HasColumnType("double");  
            builder.Property(c => c.VLTOTAL).HasColumnName("VLTOTAL").HasColumnType("double");  
            builder.Property(c => c.DSOBS).HasColumnName("DSOBS").HasColumnType("mediumtext");

            //chaves estrangeiras
            
            builder
                .HasMany(pedido => pedido.PedidoItem)
                .WithOne(pedidoItem => pedidoItem.Pedido)
                .HasForeignKey(pedidoItem => new { pedidoItem.IDPEDIDO })
                .HasPrincipalKey(pedido => new { pedido.Id })
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasMany(pedido => pedido.PedidoPagamento)
                .WithOne(pedidoPag => pedidoPag.Pedido)
                .HasForeignKey(pedidoPag => new { pedidoPag.IDPEDIDO })
                .HasPrincipalKey(pedido => new { pedido.Id })
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasMany(pedido => pedido.Pedidovenda)
                .WithOne(pedidoVenda => pedidoVenda.Pedido)
                .HasForeignKey(pedidoVenda => new { pedidoVenda.IDPEDIDO })
                .HasPrincipalKey(pedido => new { pedido.Id })
                .OnDelete(DeleteBehavior.Cascade);


            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Ativo);
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);
        }
    }
}
