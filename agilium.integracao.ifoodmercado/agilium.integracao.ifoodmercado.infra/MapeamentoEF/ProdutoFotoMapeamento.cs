using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class ProdutoFotoMapeamento : IEntityTypeConfiguration<ProdutoFoto>
    {
        public void Configure(EntityTypeBuilder<ProdutoFoto> builder)
        {
            builder.ToTable("prod_foto");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("IDPROD_FOTO").HasColumnType("bigint").IsRequired();
            builder.Property(c => c.idProduto).HasColumnName("IDPRODUTO").HasColumnType("bigint");
            builder.Property(c => c.Descricao).HasColumnName("DSFOTO").HasColumnType("mediumtext");
            builder.Property(c => c.Foto).HasColumnName("FOTO").HasColumnType("mediumblob");
            builder.Property(c => c.Data).HasColumnName("DTHRCADFOTO").HasColumnType("datetime");

            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Ativo);
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);
        }
    }
}

//IDPROD_FOTO bigint PK
//IDPRODUTO bigint
//DSFOTO mediumtext
//DTHRCADFOTO datetime
//FOTO mediumblob
