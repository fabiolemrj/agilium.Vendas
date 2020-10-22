using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class CaixaMoedaMapeamento : IEntityTypeConfiguration<CaixaMoeda>
    {
        public void Configure(EntityTypeBuilder<CaixaMoeda> builder)
        {
            builder.ToTable("caixa_moeda");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("IDCAIXA_MOEDA").HasColumnType("bigint").IsRequired();
            builder.Property(c => c.IDCAIXA).HasColumnName("IDCAIXA").HasColumnType("bigint");  
            builder.Property(c => c.IDMOEDA).HasColumnName("IDMOEDA").HasColumnType("bigint");  
            builder.Property(c => c.VLMOEDAORIGINAL).HasColumnName("VLMOEDAORIGINAL").HasColumnType("double");  
            builder.Property(c => c.VLMOEDACORRECAO).HasColumnName("VLMOEDACORRECAO").HasColumnType("double");  
            builder.Property(c => c.IDUSUARIOCORRECAO).HasColumnName("IDUSUARIOCORRECAO").HasColumnType("bigint");  
            builder.Property(c => c.DTHRCORRECAO).HasColumnName("DTHRCORRECAO").HasColumnType("datetime");

            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Ativo);
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);
        }
    }
}
