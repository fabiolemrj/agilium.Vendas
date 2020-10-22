using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class GrupoProdutoMapeamento : IEntityTypeConfiguration<GrupoProduto>
    {
        public void Configure(EntityTypeBuilder<GrupoProduto> builder)
        {
            builder.ToTable("prod_grupo");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("IDGRUPO").HasColumnType("bigint").IsRequired();
            builder.Property(c => c.idEmpresa).HasColumnName("IDEMPRESA").HasColumnType("bigint").IsRequired();
            builder.Property(c => c.Nome).HasColumnName("NMGRUPO").HasColumnType("varchar(50)");
            builder.Property(c => c.Codigo).HasColumnName("CDGRUPO").HasColumnType("varchar(6)");
            builder.Property(x => x.Ativo).HasColumnType("int").HasColumnName("STATIVO");

            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);
        }
    }

//    IDGRUPO bigint PK
//IDEMPRESA bigint
//CDGRUPO varchar(6)
//NMGRUPO varchar(50)
//STATIVO int
}
