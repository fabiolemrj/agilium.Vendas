using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class FormaPagamentoMapeamento : IEntityTypeConfiguration<FormaPagamento>
    {
        public void Configure(EntityTypeBuilder<FormaPagamento> builder)
        {
            builder.ToTable("forma_pagamento");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("IDFORMAPAG").HasColumnType("bigint").IsRequired();  
            builder.Property(c => c.IDEMPRESA).HasColumnName("IDEMPRESA").HasColumnType("bigint"); 
            builder.Property(c => c.DSFORMAPAG).HasColumnName("DSFORMAPAG").HasColumnType("varchar(50)");  
            builder.Property(c => c.STFORMAPAG).HasColumnName("STFORMAPAG").HasColumnType("int");

            //chaves estrangeiras

            builder
                .HasMany(formapag => formapag.PedidoPagamento)
                .WithOne(pedidoPag => pedidoPag.FormaPagamento)
                .HasForeignKey(pedidoPag => new { pedidoPag.IDFORMAPAG })
                .HasPrincipalKey(formapag => new { formapag.Id })
                .OnDelete(DeleteBehavior.Cascade);

            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Ativo);
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);
        }
    }
}
