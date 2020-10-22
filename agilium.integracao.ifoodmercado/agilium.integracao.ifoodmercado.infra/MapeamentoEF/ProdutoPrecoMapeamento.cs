using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class ProdutoPrecoMapeamento : IEntityTypeConfiguration<ProdutoPreco>
    {
        public void Configure(EntityTypeBuilder<ProdutoPreco> builder)
        {
            builder.ToTable("prod_preco");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("IDPROD_PRECO").HasColumnType("bigint").IsRequired();
            builder.Property(c => c.idProduto).HasColumnName("IDPRODUTO").HasColumnType("bigint");
            builder.Property(c => c.Usuario).HasColumnName("USUARIO").HasColumnType("varchar(50)");
            builder.Property(c => c.Preco).HasColumnName("NUPRECO_NEW").HasColumnType("double");
            builder.Property(c => c.PrecoAnterior).HasColumnName("NUPRECO_OLD").HasColumnType("double");
            builder.Property(c => c.DataPreco).HasColumnName("DTPROD_PRECO").HasColumnType("datetime");


            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Ativo);
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);
        }
    }
}

//IDPROD_PRECO bigint PK
//IDPRODUTO bigint
//USUARIO varchar(50)
//NUPRECO_NEW double
//NUPRECO_OLD double
//DTPROD_PRECO datetime
