using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class PedidoItemVendaItemMapeamento : IEntityTypeConfiguration<PedidoItemVendaItem>
    {
        public void Configure(EntityTypeBuilder<PedidoItemVendaItem> builder)
        {
            builder.ToTable("pedido_item_venda_item");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("IDPEDITVENDIT").HasColumnType("bigint").IsRequired();

            builder.Property(c => c.IDITEMPEDIDO).HasColumnName("IDITEMPEDIDO").HasColumnType("bigint");  
            builder.Property(c => c.IDVENDA_ITEM).HasColumnName("IDVENDA_ITEM").HasColumnType("bigint");

  

            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Ativo);
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);
        }
    }
}
