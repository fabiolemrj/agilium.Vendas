using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class ConfiguracaoImagemMapeamento : IEntityTypeConfiguration<ConfiguracaoImagem>
    {
        public void Configure(EntityTypeBuilder<ConfiguracaoImagem> builder)
        {
            builder.ToTable("config_img");
            builder.HasKey(c => c.CHAVE);

            builder.Property(c => c.CHAVE).HasColumnName("CHAVE").HasColumnType("varchar(30)").IsRequired();

            builder.Property(c => c.IDEMPRESA).HasColumnName("IDEMPRESA").HasColumnType("bigint");
            builder.Property(c => c.IMG).HasColumnName("IMG").HasColumnType("mediumblob");

            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Ativo);
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);
            builder.Ignore(c => c.Id);
        }
    }
}
