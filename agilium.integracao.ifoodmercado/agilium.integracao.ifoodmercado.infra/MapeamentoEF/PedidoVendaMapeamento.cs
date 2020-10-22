using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class PedidoVendaMapeamento : IEntityTypeConfiguration<PedidoVenda>
    {
        public void Configure(EntityTypeBuilder<PedidoVenda> builder)
        {
            builder.ToTable("pedido_venda");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("IDPEDIDOVENDA").HasColumnType("bigint").IsRequired();

            builder.Property(c => c.IDPEDIDO).HasColumnName("IDPEDIDO").HasColumnType("bigint");  
            builder.Property(c => c.IDVENDA).HasColumnName("IDVENDA").HasColumnType("bigint");

            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Ativo);
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);
        }
    }
}
