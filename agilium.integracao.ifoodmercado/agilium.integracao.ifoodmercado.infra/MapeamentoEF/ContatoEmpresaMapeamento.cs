using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class ContatoEmpresaMapeamento : IEntityTypeConfiguration<ContatoEmpresa>
    {
        public void Configure(EntityTypeBuilder<ContatoEmpresa> builder)
        {
            builder.ToTable("empresa_contato");

            builder.HasKey(c => new { c.IDCONTATO, c.IDEMPRESA });

            builder.Property(c => c.IDCONTATO).HasColumnName("IDCONTATO").HasColumnType("bigint").IsRequired();
            builder.Property(c => c.IDEMPRESA).HasColumnName("IDEMPRESA").HasColumnType("bigint").IsRequired();

            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Ativo);
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);
            builder.Ignore(c => c.Id);
        }
    }
}
