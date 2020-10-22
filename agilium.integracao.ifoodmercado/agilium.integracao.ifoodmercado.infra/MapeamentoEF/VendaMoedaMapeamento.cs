using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class VendaMoedaMapeamento : IEntityTypeConfiguration<VendaMoeda>
    {
        public void Configure(EntityTypeBuilder<VendaMoeda> builder)
        {
            builder.ToTable("venda_moeda");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("IDVENDA_MOEDA").HasColumnType("bigint").IsRequired();
            builder.Property(c => c.IDVENDA).HasColumnName("IDVENDA").HasColumnType("bigint");  
            builder.Property(c => c.IDMOEDA).HasColumnName("IDMOEDA").HasColumnType("bigint");  
            builder.Property(c => c.IDVALE).HasColumnName("IDVALE").HasColumnType("bigint");  
            builder.Property(c => c.VLPAGO).HasColumnName("VLPAGO").HasColumnType("double");  
            builder.Property(c => c.VLTROCO).HasColumnName("VLTROCO").HasColumnType("double");  
            builder.Property(c => c.NUPARCELAS).HasColumnName("NUPARCELAS").HasColumnType("int");  
            builder.Property(c => c.NSU).HasColumnName("NSU").HasColumnType("varchar(20)");

            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Ativo);
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);
        }
    }
}
