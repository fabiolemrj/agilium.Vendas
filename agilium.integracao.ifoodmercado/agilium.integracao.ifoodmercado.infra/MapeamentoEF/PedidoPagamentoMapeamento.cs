using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class PedidoPagamentoMapeamento : IEntityTypeConfiguration<PedidoPagamento>
    {
        public void Configure(EntityTypeBuilder<PedidoPagamento> builder)
        {
            builder.ToTable("pedido_pagamento");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("IDPEDIDOPAG").HasColumnType("bigint").IsRequired();

            builder.Property(c => c.IDPEDIDO).HasColumnName("IDPEDIDO").HasColumnType("bigint");  
            builder.Property(c => c.IDFORMAPAG).HasColumnName("IDFORMAPAG").HasColumnType("bigint"); 
            builder.Property(c => c.IDMOEDA).HasColumnName("IDMOEDA").HasColumnType("bigint");  
            builder.Property(c => c.VLPAG).HasColumnName("VLPAG").HasColumnType("double");  
            builder.Property(c => c.DSOBSPAG).HasColumnName("DSOBSPAG").HasColumnType("varchar(200)");

            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Ativo);
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);
        }
    }
}
