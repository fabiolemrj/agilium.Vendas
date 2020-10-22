using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class TurnoPrecoMapeamento : IEntityTypeConfiguration<TurnoPreco>
    {
        public void Configure(EntityTypeBuilder<TurnoPreco> builder)
        {
            builder.ToTable("turno_preco");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("IDTURNO_PRECO").HasColumnType("bigint").IsRequired();

            builder.Property(c => c.IDPRODUTO).HasColumnName("IDPRODUTO").HasColumnType("bigint");  
            builder.Property(c => c.NUTURNO).HasColumnName("NUTURNO").HasColumnType("int");  
            builder.Property(c => c.TPDIFERENCA).HasColumnName("TPDIFERENCA").HasColumnType("int");  
            builder.Property(c => c.TPVALOR).HasColumnName("TPVALOR").HasColumnType("int");  
            builder.Property(c => c.NUVALOR).HasColumnName("NUVALOR").HasColumnType("double");  
            builder.Property(c => c.NMUSUARIO).HasColumnName("NMUSUARIO").HasColumnType("varchar(50)");  
            builder.Property(c => c.DTHRCAD).HasColumnName("DTHRCAD").HasColumnType("datetime");

            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Ativo);
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);
        }
    }
}
