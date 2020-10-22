using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class InventarioItemMapeamento : IEntityTypeConfiguration<InventarioItem>
    {
        public void Configure(EntityTypeBuilder<InventarioItem> builder)
        {
            builder.ToTable("inventario_item");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("IDINVENTITEM").HasColumnType("bigint").IsRequired();

            builder.Property(c => c.IDINVENT).HasColumnName("IDINVENT").HasColumnType("bigint");  
            builder.Property(c => c.IDPRODUTO).HasColumnName("IDPRODUTO").HasColumnType("bigint");  
            builder.Property(c => c.IDPERDA).HasColumnName("IDPERDA").HasColumnType("bigint");  
            builder.Property(c => c.IDUSUARIOANALISE).HasColumnName("IDUSUARIOANALISE").HasColumnType("bigint");  
            builder.Property(c => c.DTHRANALISE).HasColumnName("DTHRANALISE").HasColumnType("datetime");  
            builder.Property(c => c.NUQTDANALISE).HasColumnName("NUQTDANALISE").HasColumnType("double");  
            builder.Property(c => c.NUQTDESTOQUE).HasColumnName("NUQTDESTOQUE").HasColumnType("double");  
            builder.Property(c => c.VLCUSTOMEDIO).HasColumnName("VLCUSTOMEDIO").HasColumnType("double");

            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Ativo);
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);
        }
    }
}
