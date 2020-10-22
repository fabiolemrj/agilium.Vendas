using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class ProdutoComposicaoMapeamento : IEntityTypeConfiguration<ProdutoComposicao>
    {
        public void Configure(EntityTypeBuilder<ProdutoComposicao> builder)
        {
            builder.ToTable("prod_composicao");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("IDCOMPOSICAO").HasColumnType("bigint").IsRequired();
            builder.Property(c => c.idProduto).HasColumnName("IDPRODUTO").HasColumnType("bigint");
            builder.Property(c => c.idProdutoComposicao).HasColumnName("IDPRODUTO_COMP").HasColumnType("bigint");
            builder.Property(c => c.idEstoque).HasColumnName("IDESTOQUE").HasColumnType("bigint");
            builder.Property(c => c.Quantidade).HasColumnName("NUQTD").HasColumnType("double");
            builder.Property(c => c.Preco).HasColumnName("NUPRECO").HasColumnType("double");

            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Ativo);
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);
        }
    }
}
//IDCOMPOSICAO bigint PK
//IDPRODUTO bigint
//IDPRODUTO_COMP bigint
//IDESTOQUE bigint
//NUQTD double
//NUPRECO double