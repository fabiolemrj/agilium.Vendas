using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class CaAreaMapeamento : IEntityTypeConfiguration<CaArea>
    {
        public void Configure(EntityTypeBuilder<CaArea> builder)
        {
            builder.ToTable("ca_areas");
            builder.HasKey(c => c.id_area);

            builder.Property(c => c.id_area).HasColumnName("id_area").HasColumnType("int").IsRequired();
            builder.Property(c => c.hierarquia).HasColumnName("hierarquia").HasColumnType("int");
            builder.Property(c => c.ordem).HasColumnName("ordem").HasColumnType("int");  
            builder.Property(c => c.titulo).HasColumnName("titulo").HasColumnType("varchar(50)");  
            builder.Property(c => c.subitem).HasColumnName("subitem").HasColumnType("int");  
            builder.Property(c => c.idtag).HasColumnName("idtag").HasColumnType("int");

            //chaves estrangeiras
            builder
                .HasMany(caArea => caArea.CaPermissao)
                .WithOne(caPermissao => caPermissao.CaArea)
                .HasForeignKey(caPermissao => new { caPermissao.id_area })
                .HasPrincipalKey(caArea => new { caArea.id_area })
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
