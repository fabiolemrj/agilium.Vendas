using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class CompraMapeamento : IEntityTypeConfiguration<Compra>
    {
        public void Configure(EntityTypeBuilder<Compra> builder)
        {
            builder.ToTable("compra");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("IDCOMPRA").HasColumnType("bigint").IsRequired();

            builder.Property(c => c.IDEMPRESA).HasColumnName("IDEMPRESA").HasColumnType("bigint");  
            builder.Property(c => c.IDFORN).HasColumnName("IDFORN").HasColumnType("bigint");  
            builder.Property(c => c.IDTURNO).HasColumnName("IDTURNO").HasColumnType("bigint");  
            builder.Property(c => c.DTCOMPRA).HasColumnName("DTCOMPRA").HasColumnType("date"); 
            builder.Property(c => c.DTCAD).HasColumnName("DTCAD").HasColumnType("datetime");  
            builder.Property(c => c.CDCOMPRA).HasColumnName("CDCOMPRA").HasColumnType("varchar(6)");  
            builder.Property(c => c.STCOMPRA).HasColumnName("STCOMPRA").HasColumnType("int");  
            builder.Property(c => c.DTNF).HasColumnName("DTNF").HasColumnType("date");  
            builder.Property(c => c.NUNF).HasColumnName("NUNF").HasColumnType("varchar(30)");  
            builder.Property(c => c.DSSERIENF).HasColumnName("DSSERIENF").HasColumnType("varchar(30)");   
            builder.Property(c => c.DSCHAVENFE).HasColumnName("DSCHAVENFE").HasColumnType("varchar(50)");   
            builder.Property(c => c.TPCOMPROVANTE).HasColumnName("TPCOMPROVANTE").HasColumnType("int");  
            builder.Property(c => c.NUCFOP).HasColumnName("NUCFOP").HasColumnType("int");  
            builder.Property(c => c.VLICMSRETIDO).HasColumnName("VLICMSRETIDO").HasColumnType("double");  
            builder.Property(c => c.VLBSCALCICMS).HasColumnName("VLBSCALCICMS").HasColumnType("double");  
            builder.Property(c => c.VLICMS).HasColumnName("VLICMS").HasColumnType("double");  
            builder.Property(c => c.VLBSCALCSUB).HasColumnName("VLBSCALCSUB").HasColumnType("double");  
            builder.Property(c => c.VLICMSSUB).HasColumnName("VLICMSSUB").HasColumnType("double");  
            builder.Property(c => c.VLISENCAO).HasColumnName("VLISENCAO").HasColumnType("double");  
            builder.Property(c => c.VLTOTPROD).HasColumnName("VLTOTPROD").HasColumnType("double");  
            builder.Property(c => c.VLFRETE).HasColumnName("VLFRETE").HasColumnType("double");  
            builder.Property(c => c.VLSEGURO).HasColumnName("VLSEGURO").HasColumnType("double");  
            builder.Property(c => c.VLDESCONTO).HasColumnName("VLDESCONTO").HasColumnType("double");  
            builder.Property(c => c.VLOUTROS).HasColumnName("VLOUTROS").HasColumnType("double");  
            builder.Property(c => c.VLIPI).HasColumnName("VLIPI").HasColumnType("double");  
            builder.Property(c => c.VLTOTAL).HasColumnName("VLTOTAL").HasColumnType("double");  
            builder.Property(c => c.DSOBS).HasColumnName("DSOBS").HasColumnType("varchar(500)");  
            builder.Property(c => c.STIMPORTADA).HasColumnName("STIMPORTADA").HasColumnType("int");

            //chaves estrangeiras
            builder
                .HasMany(compra => compra.CompraItem)
                .WithOne(compraItem => compraItem.Compra)
                .HasForeignKey(compraItem => new { compraItem.IDCOMPRA })
                .HasPrincipalKey(compra => new { compra.Id })
                 .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasMany(compra => compra.CompraFiscal)
                .WithOne(compraFiscal => compraFiscal.Compra)
                .HasForeignKey(compraFiscal => new { compraFiscal.IDCOMPRA })
                .HasPrincipalKey(compra => new { compra.Id })
                 .OnDelete(DeleteBehavior.Cascade);

            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Ativo);
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);
        }
    }
}
