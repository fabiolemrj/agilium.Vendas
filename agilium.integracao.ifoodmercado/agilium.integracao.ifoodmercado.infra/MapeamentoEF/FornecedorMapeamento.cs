using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class FornecedorMapeamento : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.ToTable("fornecedor");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).HasColumnName("IDFORN").HasColumnType("bigint").IsRequired();

            builder.Property(c => c.IDENDERECO).HasColumnName("IDENDERECO").HasColumnType("bigint");  
            builder.Property(c => c.CDFORN).HasColumnName("CDFORN").HasColumnType("varchar(6)");  
            builder.Property(c => c.NMRZSOCIAL).HasColumnName("NMRZSOCIAL").HasColumnType("varchar(70)");   
            builder.Property(c => c.NMFANTASIA).HasColumnName("NMFANTASIA").HasColumnType("varchar(70)");   
            builder.Property(c => c.TPPESSOA).HasColumnName("TPPESSOA").HasColumnType("varchar(1)");   
            builder.Property(c => c.NUCPFCNPJ).HasColumnName("NUCPFCNPJ").HasColumnType("varchar(20)");   
            builder.Property(c => c.DSINSCR).HasColumnName("DSINSCR").HasColumnType("varchar(20)");   
            builder.Property(c => c.TPFISCAL).HasColumnName("TPFISCAL").HasColumnType("int");  
            builder.Property(c => c.STFORNEC).HasColumnName("STFORNEC").HasColumnType("int");

            //chaves estrangeiras
            builder
                .HasMany(fornec => fornec.ForncedorProduto)
                .WithOne(fornecprod => fornecprod.Fornecedor)
                .HasForeignKey(fornecProd => new { fornecProd.IDFORN })
                .HasPrincipalKey(fornec => new { fornec.Id })
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasMany(fornec => fornec.FornecedorContato)
                .WithOne(fornecContato => fornecContato.Fornecedor)
                .HasForeignKey(fornecContato => new { fornecContato.IDFORN })
                .HasPrincipalKey(fornec => new { fornec.Id })
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasMany(fornec => fornec.PedidoItem)
                .WithOne(pedidoItem => pedidoItem.Fornecedor)
                .HasForeignKey(pedidoItem => new { pedidoItem.IDFORN })
                .HasPrincipalKey(fornec => new { fornec.Id })
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasMany(fornec => fornec.ContaPagar)
                .WithOne(contaPagar => contaPagar.Fornecedor)
                .HasForeignKey(contaPagar => new { contaPagar.IDFORNEC })
                .HasPrincipalKey(fornec => new { fornec.Id })
                .OnDelete(DeleteBehavior.Cascade);

            builder
              .HasMany(fornec => fornec.Compra)
              .WithOne(compra => compra.Fornecedor)
              .HasForeignKey(compra => new { compra.IDFORN })
              .HasPrincipalKey(fornec => new { fornec.Id })
              .OnDelete(DeleteBehavior.Cascade);

            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Ativo);
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);
        }
    }
}
