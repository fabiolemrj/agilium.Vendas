using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class VendaCanceladaMapeamento : IEntityTypeConfiguration<VendaCancelada>
    {
        public void Configure(EntityTypeBuilder<VendaCancelada> builder)
        {
            builder.ToTable("venda_cancel");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("IDVENDACANCEL").HasColumnType("bigint").IsRequired();

            builder.Property(c => c.IDVENDA).HasColumnName("IDVENDA").HasColumnType("bigint");  
            builder.Property(c => c.IDUSUARIOCANCEL).HasColumnName("IDUSUARIOCANCEL").HasColumnType("bigint");  
            builder.Property(c => c.DTHRCANCEL).HasColumnName("DTHRCANCEL").HasColumnType("datetime");  
            builder.Property(c => c.DSMOTIVO).HasColumnName("DSMOTIVO").HasColumnType("varchar(500)");  
            builder.Property(c => c.DSPROTOCOLO).HasColumnName("DSPROTOCOLO").HasColumnType("varchar(50)");   
            builder.Property(c => c.DSXML).HasColumnName("DSXML").HasColumnType("mediumtext");
            
            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Ativo);
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);
        }
    }
}
