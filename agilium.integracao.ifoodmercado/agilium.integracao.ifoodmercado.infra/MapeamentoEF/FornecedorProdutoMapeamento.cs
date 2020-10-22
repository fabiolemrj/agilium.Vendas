using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class FornecedorProdutoMapeamento : IEntityTypeConfiguration<FornecedorProduto>
    {
        public void Configure(EntityTypeBuilder<FornecedorProduto> builder)
        {
            builder.ToTable("forn_prod");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).HasColumnName("IDFORN_PROD").HasColumnType("bigint").IsRequired();

            builder.Property(c => c.IDFORN).HasColumnName("IDFORN").HasColumnType("bigint");  
            builder.Property(c => c.IDPRODUTO).HasColumnName("IDPRODUTO").HasColumnType("bigint");


            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Ativo);
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);
        }
    }
}
