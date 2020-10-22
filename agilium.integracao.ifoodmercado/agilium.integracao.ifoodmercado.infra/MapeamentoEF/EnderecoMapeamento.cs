using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class EnderecoMapeamento : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("endereco");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("IDENDERECO").HasColumnType("bigint").IsRequired();
            builder.Property(c => c.Logradouro).HasColumnName("ENDER").HasColumnType("varchar(90)").IsRequired();
            builder.Property(c => c.Complemento).HasColumnType("varchar(40)").HasColumnName("COMPL");
            builder.Property(c => c.Numero).HasColumnType("varchar(20)").HasColumnName("NUM");
            builder.Property(c => c.Bairro).HasColumnType("varchar(75)").HasColumnName("BAIRRO");
            builder.Property(c => c.Cidade).HasColumnType("varchar(65)").HasColumnName("CIDADE");
            builder.Property(c => c.Uf).HasColumnType("varchar(2)").HasColumnName("UF");
            builder.Property(c => c.Pais).HasColumnType("varchar(30)").HasColumnName("PAIS");

            builder.Property(x => x.Ibge).HasColumnType("int").HasColumnName("IBGE");
            builder.Property(x => x.PontoReferencia).HasColumnType("varchar(100)").HasColumnName("DSPTREF");

          //  chaves estrangeiras
            builder
            .HasMany(endereco => endereco.Empresas)
            .WithOne(empresa => empresa.Endereco)
            .HasForeignKey(empresa => empresa.IDENDERECO)
            .HasPrincipalKey(end => new { end.Id })
             .OnDelete(DeleteBehavior.Cascade);

            builder
             .HasMany(endereco => endereco.Clientes)
             .WithOne(cliEndereco => cliEndereco.Endereco)
             .HasForeignKey(cliEndereco => cliEndereco.IDENDERECO)
             .HasPrincipalKey(end => new { end.Id })
              .OnDelete(DeleteBehavior.Cascade);

            builder
             .HasMany(endereco => endereco.ClientesCobranca)
             .WithOne(clicob => clicob.EnderecoCobranca)
             .HasForeignKey(clicob => clicob.IDENDERECOCOB)
             .HasPrincipalKey(end => new { end.Id })
              .OnDelete(DeleteBehavior.Cascade);

            builder
              .HasMany(endereco => endereco.ClientesFaturamento)
              .WithOne(clicob => clicob.EnderecoFaturamento)
              .HasForeignKey(clicob => clicob.IDENDERECOFAT)
              .HasPrincipalKey(end => new { end.Id })
               .OnDelete(DeleteBehavior.Cascade);

            builder
              .HasMany(endereco => endereco.Funcionarios)
              .WithOne(func => func.Endereco)
              .HasForeignKey(func => func.IDENDERECO)
              .HasPrincipalKey(end => new { end.Id })
               .OnDelete(DeleteBehavior.Cascade);

            builder
               .HasMany(endereco => endereco.Fornecedor)
               .WithOne(fornec => fornec.Endereco)
               .HasForeignKey(fornec => fornec.IDENDERECO)
               .HasPrincipalKey(end => new { end.Id })
                .OnDelete(DeleteBehavior.Cascade);

            builder
               .HasMany(endereco => endereco.Pedidos)
               .WithOne(pedido => pedido.Endereco)
               .HasForeignKey(pedido => pedido.IDENDERECO)
               .HasPrincipalKey(end => new { end.Id })
                .OnDelete(DeleteBehavior.Cascade);


            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Ativo);
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);
        }
    }
}
