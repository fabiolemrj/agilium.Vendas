using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class CaPerfilMapeamento : IEntityTypeConfiguration<CaPerfil>
    {
        public void Configure(EntityTypeBuilder<CaPerfil> builder)
        {
            builder.ToTable("ca_perfis");
            builder.HasKey(c => c.id_perfil);

            builder.Property(c => c.id_perfil).HasColumnName("id_perfil").HasColumnType("int").IsRequired();
            builder.Property(c => c.descricao).HasColumnName("descricao").HasColumnType("varchar(50)");

            //chaves estrangeiras
            builder
                .HasMany(caPerfil => caPerfil.CaPermissao)
                .WithOne(caPermissao => caPermissao.CaPerfil)
                .HasForeignKey(caPermissao => new { caPermissao.id_perfil })
                .HasPrincipalKey(caPerfil => new { caPerfil.id_perfil })
                 .OnDelete(DeleteBehavior.Cascade);

            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Ativo);
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);
            builder.Ignore(c => c.Id);
        }
    }
}
