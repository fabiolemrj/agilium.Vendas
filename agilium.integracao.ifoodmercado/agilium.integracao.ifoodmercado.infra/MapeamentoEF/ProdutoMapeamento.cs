using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class ProdutoMapeamento : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("produto");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("IDPRODUTO").HasColumnType("bigint").IsRequired();
            builder.Property(c => c.idEmpresa).HasColumnName("IDEMPRESA").HasColumnType("bigint");

            builder.Property(c => c.IDGRUPO).HasColumnName("IDGRUPO").HasColumnType("bigint");  
            builder.Property(c => c.CDPRODUTO).HasColumnName("CDPRODUTO").HasColumnType("varchar(6)");  
            builder.Property(c => c.NMPRODUTO).HasColumnName("NMPRODUTO").HasColumnType("varchar(50)");   
            builder.Property(c => c.CTPRODUTO).HasColumnName("CTPRODUTO").HasColumnType("varchar(1)");   
            builder.Property(c => c.TPPRODUTO).HasColumnName("TPPRODUTO").HasColumnType("int");  
            builder.Property(c => c.UNCOMPRA).HasColumnName("UNCOMPRA").HasColumnType("varchar(5)");  
            builder.Property(c => c.UNVENDA).HasColumnName("UNVENDA").HasColumnType("varchar(5)");   
            builder.Property(c => c.NURELACAO).HasColumnName("NURELACAO").HasColumnType("int");  
            builder.Property(c => c.NUPRECO).HasColumnName("NUPRECO").HasColumnType("double");  
            builder.Property(c => c.NUQTDMIN).HasColumnName("NUQTDMIN").HasColumnType("double");  
            builder.Property(c => c.CDSEFAZ).HasColumnName("CDSEFAZ").HasColumnType("varchar(20)");  
            builder.Property(c => c.CDANP).HasColumnName("CDANP").HasColumnType("varchar(20)");   
            builder.Property(c => c.CDNCM).HasColumnName("CDNCM").HasColumnType("varchar(20)");   
            builder.Property(c => c.CDCEST).HasColumnName("CDCEST").HasColumnType("varchar(20)");   
            builder.Property(c => c.CDSERV).HasColumnName("CDSERV").HasColumnType("varchar(20)");   
            builder.Property(c => c.Ativo).HasColumnName("STPRODUTO").HasColumnType("int");  
            builder.Property(c => c.VLULTIMACOMPRA).HasColumnName("VLULTIMACOMPRA").HasColumnType("double");  
            builder.Property(c => c.VLCUSTOMEDIO).HasColumnName("VLCUSTOMEDIO").HasColumnType("double");  
            builder.Property(c => c.PCIBPTFED).HasColumnName("PCIBPTFED").HasColumnType("double");  
            builder.Property(c => c.PCIBPTEST).HasColumnName("PCIBPTEST").HasColumnType("double");  
            builder.Property(c => c.PCIBPTMUN).HasColumnName("PCIBPTMUN").HasColumnType("double");  
            builder.Property(c => c.PCIBPTIMP).HasColumnName("PCIBPTIMP").HasColumnType("double");  
            builder.Property(c => c.NUCFOP).HasColumnName("NUCFOP").HasColumnType("int");  
            builder.Property(c => c.STORIGEMPROD).HasColumnName("STORIGEMPROD").HasColumnType("int");  
            builder.Property(c => c.DSCOFINS_CST).HasColumnName("DSICMS_CST").HasColumnType("varchar(5)");  
            builder.Property(c => c.PCICMS_ALIQ).HasColumnName("PCICMS_ALIQ").HasColumnType("double");  
            builder.Property(c => c.PCICMS_REDUCBC).HasColumnName("PCICMS_REDUCBC").HasColumnType("double");  
            builder.Property(c => c.PCICMSST_ALIQ).HasColumnName("PCICMSST_ALIQ").HasColumnType("double");  
            builder.Property(c => c.PCICMSST_MVA).HasColumnName("PCICMSST_MVA").HasColumnType("double");  
            builder.Property(c => c.PCICMSST_REDUCBC).HasColumnName("PCICMSST_REDUCBC").HasColumnType("double");  
            builder.Property(c => c.DSIPI_CST).HasColumnName("DSIPI_CST").HasColumnType("varchar(5)");  
            builder.Property(c => c.PCIPI_ALIQ).HasColumnName("PCIPI_ALIQ").HasColumnType("double");  
            builder.Property(c => c.DSPIS_CST).HasColumnName("DSPIS_CST").HasColumnType("varchar(5)");  
            builder.Property(c => c.PCPIS_ALIQ).HasColumnName("PCPIS_ALIQ").HasColumnType("double");  
            builder.Property(c => c.DSCOFINS_CST).HasColumnName("DSCOFINS_CST").HasColumnType("varchar(5)");  
            builder.Property(c => c.PCCOFINS_ALIQ).HasColumnName("PCCOFINS_ALIQ").HasColumnType("double");  
            builder.Property(c => c.STESTOQUE).HasColumnName("STESTOQUE").HasColumnType("int");  
            builder.Property(c => c.FLG_IFOOD).HasColumnName("FLG_IFOOD").HasColumnType("int");

            //chaves estrangeiras
            builder
             .HasMany(prod => prod.ProdutoComposicao)
             .WithOne(comp => comp.Produto)
             .HasForeignKey(comp => new { comp.idProduto })
             .HasPrincipalKey(prod => new { prod.Id })
             .OnDelete(DeleteBehavior.Cascade);

            builder
             .HasMany(prod => prod.ProdutoFoto)
             .WithOne(foto => foto.Produto)
             .HasForeignKey(foto => new { foto.idProduto })
             .HasPrincipalKey(prod => new { prod.Id })
             .OnDelete(DeleteBehavior.Cascade);

            builder
             .HasMany(prod => prod.ProdutoPreco)
             .WithOne(preco => preco.Produto)
             .HasForeignKey(preco => new { preco.idProduto })
             .HasPrincipalKey(prod => new { prod.Id })
             .OnDelete(DeleteBehavior.Cascade);

            builder
            .HasMany(prod => prod.EstoqueProdutos)
            .WithOne(estoque => estoque.Produto)
            .HasForeignKey(estoque => new { estoque.IDPRODUTO })
            .HasPrincipalKey(prod => new { prod.Id })
            .OnDelete(DeleteBehavior.Cascade);

            builder
              .HasMany(produto => produto.EstoqueHistoricos)
              .WithOne(historico => historico.Produto)
              .HasForeignKey(historico => new { historico.IDPRODUTO })
              .HasPrincipalKey(produto => new { produto.Id })
              .OnDelete(DeleteBehavior.Cascade);

            builder
               .HasMany(produto => produto.ProdutoCodigoBarras)
               .WithOne(codigo => codigo.Produto)
               .HasForeignKey(codigo => new { codigo.IDPRODUTO })
               .HasPrincipalKey(produto => new { produto.Id })
               .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasMany(produto => produto.ClientePrecos)
                .WithOne(preco => preco.Produto)
                .HasForeignKey(preco => new { preco.IDPRODUTO })
                .HasPrincipalKey(produto => new { produto.Id })
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasMany(produto => produto.VendaItem)
                .WithOne(vendaItem => vendaItem.Produto)
                .HasForeignKey(vendaItem => new { vendaItem.IDPRODUTO })
                .HasPrincipalKey(produto => new { produto.Id })
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasMany(produto => produto.VendaTemporariaItem)
                .WithOne(vendatempItem => vendatempItem.Produto)
                .HasForeignKey(vendatempItem => new { vendatempItem.IDPRODUTO })
                .HasPrincipalKey(produto => new { produto.Id })
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasMany(produto => produto.TurnoPreco)
                .WithOne(turnoPreco => turnoPreco.Produto)
                .HasForeignKey(turnoPreco => new { turnoPreco.IDPRODUTO })
                .HasPrincipalKey(produto => new { produto.Id })
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasMany(produto => produto.ForncedorProduto)
                .WithOne(fornecProd => fornecProd.Produto)
                .HasForeignKey(fornecProd => new { fornecProd.IDPRODUTO })
                .HasPrincipalKey(produto => new { produto.Id })
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasMany(produto => produto.PedidoItem)
                .WithOne(pedidoItem => pedidoItem.Produto)
                .HasForeignKey(pedidoItem => new { pedidoItem.IDPRODUTO })
                .HasPrincipalKey(produto => new { produto.Id })
                .OnDelete(DeleteBehavior.Cascade);

            builder
               .HasMany(produto => produto.Perdas)
               .WithOne(perda => perda.Produto)
               .HasForeignKey(perda => new { perda.IDPRODUTO })
               .HasPrincipalKey(produto => new { produto.Id })
               .OnDelete(DeleteBehavior.Cascade);

            builder
               .HasMany(produto => produto.Inventario)
               .WithOne(inventarioItem => inventarioItem.Produto)
               .HasForeignKey(inventarioItem => new { inventarioItem.IDPRODUTO })
               .HasPrincipalKey(produto => new { produto.Id })
               .OnDelete(DeleteBehavior.Cascade);

            builder
               .HasMany(produto => produto.CompraItem)
               .WithOne(compraItem => compraItem.Produto)
               .HasForeignKey(compraItem => new { compraItem.IDPRODUTO })
               .HasPrincipalKey(produto => new { produto.Id })
               .OnDelete(DeleteBehavior.Cascade);

            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);
        }
    }
}

//IDPRODUTO bigint PK
//IDEMPRESA bigint
//IDGRUPO bigint
//CDPRODUTO varchar(6)
//NMPRODUTO varchar(50)
//CTPRODUTO varchar(1)
//TPPRODUTO int
//UNCOMPRA varchar(5)
//UNVENDA varchar(5)
//NURELACAO int
//NUPRECO double
//NUQTDMIN double
//CDSEFAZ varchar(20)
//CDANP varchar(20)
//CDNCM varchar(20)
//CDCEST varchar(20)
//CDSERV varchar(20)
//STPRODUTO int
//VLULTIMACOMPRA double
//VLCUSTOMEDIO double
//PCIBPTFED double
//PCIBPTEST double
//PCIBPTMUN double
//PCIBPTIMP double
//NUCFOP int
//STORIGEMPROD int
//DSICMS_CST varchar(5)
//PCICMS_ALIQ double
//PCICMS_REDUCBC double
//PCICMSST_ALIQ double
//PCICMSST_MVA double
//PCICMSST_REDUCBC double
//DSIPI_CST varchar(5)
//PCIPI_ALIQ double
//DSPIS_CST varchar(5)
//PCPIS_ALIQ double
//DSCOFINS_CST varchar(5)
//PCCOFINS_ALIQ double
//STESTOQUE int
//FLG_IFOOD int
