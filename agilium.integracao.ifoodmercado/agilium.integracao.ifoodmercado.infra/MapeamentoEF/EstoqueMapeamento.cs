using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class EstoqueMapeamento : IEntityTypeConfiguration<Estoque>
    {
        public void Configure(EntityTypeBuilder<Estoque> builder)
        {
            builder.ToTable("estoque");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("IDESTOQUE").HasColumnType("bigint").IsRequired();
            builder.Property(c => c.idEmpresa).HasColumnName("IDEMPRESA").HasColumnType("bigint");
            builder.Property(c => c.Descricao).HasColumnName("DSESTOQUE").HasColumnType("varchar(50)");
            builder.Property(x => x.Tipo).HasColumnType("int").HasColumnName("TPESTOQUE");
            builder.Property(c => c.Capacidade).HasColumnName("NUCAPACIDADE").HasColumnType("double(10,3)");
            builder.Property(x => x.Ativo).HasColumnType("int").HasColumnName("STESTOQUE");
            
            //chaves estrangeiras
            builder
                .HasMany(estoque => estoque.EstoqueProdutos)
                .WithOne(produto => produto.Estoque)
                .HasForeignKey(produto => new { produto.IDESTOQUE })
                .HasPrincipalKey(estoque => new { estoque.Id })
                .OnDelete(DeleteBehavior.Cascade);

            builder
              .HasMany(estoque => estoque.EstoqueHistorico)
              .WithOne(historico => historico.Estoque)
              .HasForeignKey(historico => new { historico.IDESTOQUE })
              .HasPrincipalKey(estoque => new { estoque.Id })
              .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasMany(estoque => estoque.PontoVenda)
                .WithOne(pontoVenda => pontoVenda.Estoque)
                .HasForeignKey(pontoVenda => new { pontoVenda.IDESTOQUE })
                .HasPrincipalKey(estoque => new { estoque.Id })
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasMany(estoque => estoque.PedidoItem)
                .WithOne(pedidoItem => pedidoItem.Estoque)
                .HasForeignKey(pedidoItem => new { pedidoItem.IDESTOQUE })
                .HasPrincipalKey(estoque => new { estoque.Id })
                .OnDelete(DeleteBehavior.Cascade);

            builder
                 .HasMany(estoque => estoque.Perdas)
                 .WithOne(perda => perda.Estoque)
                 .HasForeignKey(perda => new { perda.IDESTOQUE })
                 .HasPrincipalKey(estoque => new { estoque.Id })
                 .OnDelete(DeleteBehavior.Cascade);

            builder
                 .HasMany(estoque => estoque.Inventarios)
                 .WithOne(inventario => inventario.Estoque)
                 .HasForeignKey(inventario => new { inventario.IDESTOQUE })
                 .HasPrincipalKey(estoque => new { estoque.Id })
                 .OnDelete(DeleteBehavior.Cascade);

            builder
                 .HasMany(estoque => estoque.CompraItem)
                 .WithOne(compraItem => compraItem.Estoque)
                 .HasForeignKey(compraItem => new { compraItem.IDESTOQUE })
                 .HasPrincipalKey(estoque => new { estoque.Id })
                 .OnDelete(DeleteBehavior.Cascade);

            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);
        }


    }
}

//IDESTOQUE bigint PK
//IDEMPRESA bigint
//DSESTOQUE varchar(50)
//TPESTOQUE int
//NUCAPACIDADE double (10,3) 
//STESTOQUE int
