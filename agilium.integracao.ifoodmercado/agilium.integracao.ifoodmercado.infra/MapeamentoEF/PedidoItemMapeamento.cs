using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class PedidoItemMapeamento : IEntityTypeConfiguration<PedidoItem>
    {
        public void Configure(EntityTypeBuilder<PedidoItem> builder)
        {
            builder.ToTable("pedido_item");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("IDITEMPEDIDO").HasColumnType("bigint").IsRequired();

            builder.Property(c => c.IDPEDIDO).HasColumnName("IDPEDIDO").HasColumnType("bigint");  
            builder.Property(c => c.IDPRODUTO).HasColumnName("IDPRODUTO").HasColumnType("bigint");  
            builder.Property(c => c.IDESTOQUE).HasColumnName("IDESTOQUE").HasColumnType("bigint");  
            builder.Property(c => c.IDFORN).HasColumnName("IDFORN").HasColumnType("bigint");  
            builder.Property(c => c.SQITEMPEDIDO).HasColumnName("SQITEMPEDIDO").HasColumnType("int");  
            builder.Property(c => c.VLUNIT).HasColumnName("VLUNIT").HasColumnType("double");  
            builder.Property(c => c.NUQTD).HasColumnName("NUQTD").HasColumnType("double");  
            builder.Property(c => c.VLITEM).HasColumnName("VLITEM").HasColumnType("double");  
            builder.Property(c => c.VLACRES).HasColumnName("VLACRES").HasColumnType("double");  
            builder.Property(c => c.VLDESC).HasColumnName("VLDESC").HasColumnType("double");  
            builder.Property(c => c.VLOUTROS).HasColumnName("VLOUTROS").HasColumnType("double");  
            builder.Property(c => c.VLTOTAL).HasColumnName("VLTOTAL").HasColumnType("double");  
            builder.Property(c => c.VLCUSTOMEDIO).HasColumnName("VLCUSTOMEDIO").HasColumnType("double");  
            builder.Property(c => c.STITEMPEDIDO).HasColumnName("STITEMPEDIDO").HasColumnType("int");  
            builder.Property(c => c.DTPREV_ENTREGA).HasColumnName("DTPREV_ENTREGA").HasColumnType("date");  
            builder.Property(c => c.DSOBSITEM).HasColumnName("DSOBSITEM").HasColumnType("varchar(200)");

            //chave estrangeira
            builder
                .HasMany(pedidoItem => pedidoItem.PedidosItemVendaItem)
                .WithOne(pedidoItemVenda => pedidoItemVenda.PedidoItem)
                .HasForeignKey(pedidoItemVenda => new { pedidoItemVenda.IDITEMPEDIDO })
                .HasPrincipalKey(pedidoItem => new { pedidoItem.Id })
                .OnDelete(DeleteBehavior.Cascade);

            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Ativo);
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);
        }
    }
}
