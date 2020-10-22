using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class CompraItemMapeamento : IEntityTypeConfiguration<CompraItem>
    {
        public void Configure(EntityTypeBuilder<CompraItem> builder)
        {
            builder.ToTable("compra_item");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("IDITEM").HasColumnType("bigint").IsRequired();

            builder.Property(c => c.IDCOMPRA).HasColumnName("IDCOMPRA").HasColumnType("bigint");  
            builder.Property(c => c.IDPRODUTO).HasColumnName("IDPRODUTO").HasColumnType("bigint");  
            builder.Property(c => c.IDESTOQUE).HasColumnName("IDESTOQUE").HasColumnType("bigint");  
            builder.Property(c => c.DSPRODUTO).HasColumnName("DSPRODUTO").HasColumnType("varchar(100)");  
            builder.Property(c => c.CDEAN).HasColumnName("CDEAN").HasColumnType("varchar(50)");   
            builder.Property(c => c.CDNCM).HasColumnName("CDNCM").HasColumnType("varchar(20)");   
            builder.Property(c => c.CDCEST).HasColumnName("CDCEST").HasColumnType("varchar(20)");   
            builder.Property(c => c.SGUN).HasColumnName("SGUN").HasColumnType("varchar(5)");   
            builder.Property(c => c.NUQTD).HasColumnName("NUQTD").HasColumnType("double");  
            builder.Property(c => c.NURELACAO).HasColumnName("NURELACAO").HasColumnType("double");  
            builder.Property(c => c.VLUNIT).HasColumnName("VLUNIT").HasColumnType("double");  
            builder.Property(c => c.VLTOTAL).HasColumnName("VLTOTAL").HasColumnType("double");  
            builder.Property(c => c.DTVALIDADE).HasColumnName("DTVALIDADE").HasColumnType("date");  
            builder.Property(c => c.NUCFOP).HasColumnName("NUCFOP").HasColumnType("int");  
            builder.Property(c => c.VLOUTROS).HasColumnName("VLOUTROS").HasColumnType("double");  
            builder.Property(c => c.VLBSRET).HasColumnName("VLBSRET").HasColumnType("double");  
            builder.Property(c => c.PCICMSRET).HasColumnName("PCICMSRET").HasColumnType("double");  
            builder.Property(c => c.PCREDUCAO).HasColumnName("PCREDUCAO").HasColumnType("double");  
            builder.Property(c => c.CDCSTICMS).HasColumnName("CDCSTICMS").HasColumnType("varchar(20)");  
            builder.Property(c => c.CDCSTPIS).HasColumnName("CDCSTPIS").HasColumnType("varchar(20)");   
            builder.Property(c => c.CDCSTCOFINS).HasColumnName("CDCSTCOFINS").HasColumnType("varchar(20)");   
            builder.Property(c => c.CDCSTIPI).HasColumnName("CDCSTIPI").HasColumnType("varchar(20)");   
            builder.Property(c => c.VLALIQPIS).HasColumnName("VLALIQPIS").HasColumnType("double");  
            builder.Property(c => c.VLALIQCOFINS).HasColumnName("VLALIQCOFINS").HasColumnType("double");  
            builder.Property(c => c.VLALIQICMS).HasColumnName("VLALIQICMS").HasColumnType("double");  
            builder.Property(c => c.VLALIQIPI).HasColumnName("VLALIQIPI").HasColumnType("double");  
            builder.Property(c => c.VLBSCALCPIS).HasColumnName("VLBSCALCPIS").HasColumnType("double");  
            builder.Property(c => c.VLBSCALCCOFINS).HasColumnName("VLBSCALCCOFINS").HasColumnType("double");  
            builder.Property(c => c.VLBSCALCICMS).HasColumnName("VLBSCALCICMS").HasColumnType("double");  
            builder.Property(c => c.VLBSCALCIPI).HasColumnName("VLBSCALCIPI").HasColumnType("double");  
            builder.Property(c => c.VLICMS).HasColumnName("VLICMS").HasColumnType("double");  
            builder.Property(c => c.VLPIS).HasColumnName("VLPIS").HasColumnType("double");  
            builder.Property(c => c.VLCOFINS).HasColumnName("VLCOFINS").HasColumnType("double");  
            builder.Property(c => c.VLIPI).HasColumnName("VLIPI").HasColumnType("double");  
            builder.Property(c => c.CDPRODFORN).HasColumnName("CDPRODFORN").HasColumnType("varchar(30)");  
            builder.Property(c => c.VLNOVOPRECOVENDA).HasColumnName("VLNOVOPRECOVENDA").HasColumnType("double");



            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Ativo);
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);
        }
    }
}
