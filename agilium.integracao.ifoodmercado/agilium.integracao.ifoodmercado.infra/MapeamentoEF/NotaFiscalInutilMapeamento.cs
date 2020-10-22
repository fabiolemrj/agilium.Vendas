using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class NotaFiscalInutilMapeamento : IEntityTypeConfiguration<NotaFiscalInutil>
    {
        public void Configure(EntityTypeBuilder<NotaFiscalInutil> builder)
        {

            builder.ToTable("nf_inutil");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("IDNFINUTIL").HasColumnType("bigint").IsRequired();

            builder.Property(c => c.IDEMPRESA).HasColumnName("IDEMPRESA").HasColumnType("bigint"); 
            builder.Property(c => c.CDNFINUTIL).HasColumnName("CDNFINUTIL").HasColumnType("varchar(6)");  
            builder.Property(c => c.DSMOTIVO).HasColumnName("DSMOTIVO").HasColumnType("varchar(50)");   
            builder.Property(c => c.NUANO).HasColumnName("NUANO").HasColumnType("int");  
            builder.Property(c => c.DSMODELO).HasColumnName("DSMODELO").HasColumnType("varchar(5)");  
            builder.Property(c => c.DSSERIE).HasColumnName("DSSERIE").HasColumnType("varchar(10)");   
            builder.Property(c => c.NUNFINI).HasColumnName("NUNFINI").HasColumnType("int");  
            builder.Property(c => c.NUNFFIM).HasColumnName("NUNFFIM").HasColumnType("int");  
            builder.Property(c => c.DTHRINUTIL).HasColumnName("DTHRINUTIL").HasColumnType("datetime");  
            builder.Property(c => c.STINUTIL).HasColumnName("STINUTIL").HasColumnType("int");  
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
