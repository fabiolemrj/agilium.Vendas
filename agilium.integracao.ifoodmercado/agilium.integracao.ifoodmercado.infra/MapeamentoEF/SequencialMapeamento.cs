using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class SequencialMapeamento : IEntityTypeConfiguration<Sequencial>
    {
        public void Configure(EntityTypeBuilder<Sequencial> builder)
        {
            builder.ToTable("seq");
            builder.HasKey(c => c.CHAVE);

            builder.Property(c => c.Id).HasColumnName("CHAVE").HasColumnType("varchar(30)").IsRequired();

            builder.Property(c => c.IDEMPRESA).HasColumnName("IDEMPRESA").HasColumnType("bigint");  
            builder.Property(c => c.SEQUENCIAL).HasColumnName("SEQUENCIAL").HasColumnType("int");


            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Ativo);
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);
            builder.Ignore(c => c.Id);
        }
    }
}
