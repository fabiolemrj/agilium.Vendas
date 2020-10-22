using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class CaPermissaoMapeamento : IEntityTypeConfiguration<CaPermissao>
    {
        public void Configure(EntityTypeBuilder<CaPermissao> builder)
        {
            builder.ToTable("ca_permissoes");
            builder.HasKey(c => new { c.id_perfil, c.id_area });

            builder.Property(c => c.id_area).HasColumnName("id_area").HasColumnType("int").IsRequired();
            builder.Property(c => c.id_perfil).HasColumnName("id_perfil").HasColumnType("int").IsRequired();

            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Id);
            builder.Ignore(c => c.Ativo);
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);
        }
    }
}
