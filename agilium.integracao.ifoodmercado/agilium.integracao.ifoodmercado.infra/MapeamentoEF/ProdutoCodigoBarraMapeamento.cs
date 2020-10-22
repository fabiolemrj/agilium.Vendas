using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class ProdutoCodigoBarraMapeamento : IEntityTypeConfiguration<ProdutoCodigoBarra>
    {
        public void Configure(EntityTypeBuilder<ProdutoCodigoBarra> builder)
        {
            builder.ToTable("prod_barra");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("IDPROD_BARRA").HasColumnType("bigint").IsRequired();
            builder.Property(c => c.IDPRODUTO).HasColumnName("IDPRODUTO").HasColumnType("bigint");
            builder.Property(c => c.CDBARRA).HasColumnName("CDBARRA").HasColumnType("varchar(50)");
            
            
            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Ativo);
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);
        }
    }
}
