using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class BicoMapeamento : IEntityTypeConfiguration<Bico>
    {
        public void Configure(EntityTypeBuilder<Bico> builder)
        {
            builder.ToTable("bico");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("IDBICO").HasColumnType("bigint").IsRequired();
            builder.Property(c => c.IDBOMBA).HasColumnName("IDBOMBA").HasColumnType("bigint");  
            builder.Property(c => c.CDBICO).HasColumnName("CDBICO").HasColumnType("varchar(6)");  
            builder.Property(c => c.IDESTOQUE).HasColumnName("IDESTOQUE").HasColumnType("bigint");  
            builder.Property(c => c.STBICO).HasColumnName("STBICO").HasColumnType("int");


            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Ativo);
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);
        }
    }
}
