using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class DevolucaoItemMapeamento : IEntityTypeConfiguration<DevolucaoItem>
    {
        public void Configure(EntityTypeBuilder<DevolucaoItem> builder)
        {
            builder.ToTable("devolucao_item");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).HasColumnName("IDDEV_ITEM").HasColumnType("bigint").IsRequired();

            builder.Property(c => c.IDDEV).HasColumnName("IDDEV").HasColumnType("bigint");  
            builder.Property(c => c.IDVENDA_ITEM).HasColumnName("IDVENDA_ITEM").HasColumnType("bigint");  
            builder.Property(c => c.NUQTD).HasColumnName("NUQTD").HasColumnType("double");  
            builder.Property(c => c.VLITEM).HasColumnName("VLITEM").HasColumnType("double");

            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Ativo);
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);
        }
    }
}
