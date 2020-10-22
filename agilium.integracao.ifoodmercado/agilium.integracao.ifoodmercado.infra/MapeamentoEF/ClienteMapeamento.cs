using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class ClienteMapeamento : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("cliente");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("IDCLIENTE").HasColumnType("bigint").IsRequired();

            builder.Property(c => c.CDCLIENTE).HasColumnName("CDCLIENTE").HasColumnType("varchar(6)");  
            builder.Property(c => c.NMCLIENTE).HasColumnName("NMCLIENTE").HasColumnType("varchar(70)");   
            builder.Property(c => c.TPCLIENTE).HasColumnName("TPCLIENTE").HasColumnType("varchar(1)");   
            builder.Property(c => c.DTCAD).HasColumnName("DTCAD").HasColumnType("datetime");  
            builder.Property(c => c.IDENDERECO).HasColumnName("IDENDERECO").HasColumnType("bigint");  
            builder.Property(c => c.IDENDERECOCOB).HasColumnName("IDENDERECOCOB").HasColumnType("bigint");  
            builder.Property(c => c.IDENDERECOFAT).HasColumnName("IDENDERECOFAT").HasColumnType("bigint");  
            builder.Property(c => c.STCLIENTE).HasColumnName("STCLIENTE").HasColumnType("int");

            //chaves estrangeiras
            builder
                .HasMany(cliente => cliente.ClientePessoaFisica)
                .WithOne(pf => pf.Cliente)
                .HasForeignKey(pf => new { pf.Id })
                .HasPrincipalKey(cliente => new { cliente.Id })
                 .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasMany(cliente => cliente.ClientePessoaJuridica)
                .WithOne(pj => pj.Cliente)
                .HasForeignKey(pj => new { pj.Id })
                .HasPrincipalKey(cliente => new { cliente.Id })
                 .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasMany(cliente => cliente.ClienteContatos)
                .WithOne(contato => contato.Cliente)
                .HasForeignKey(contato => new { contato.IDCLIENTE })
                .HasPrincipalKey(cliente => new { cliente.Id })
                 .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasMany(cliente => cliente.ClientePrecos)
                .WithOne(preco => preco.Cliente)
                .HasForeignKey(preco => new { preco.IDCLIENTE })
                .HasPrincipalKey(cliente => new { cliente.Id })
                 .OnDelete(DeleteBehavior.Cascade);

            builder
                 .HasMany(cliente => cliente.Venda)
                 .WithOne(venda => venda.Cliente)
                 .HasForeignKey(venda => new { venda.IDCLIENTE })
                 .HasPrincipalKey(cliente => new { cliente.Id })
                  .OnDelete(DeleteBehavior.Cascade);

            builder
                  .HasMany(cliente => cliente.Vales)
                  .WithOne(vale => vale.Cliente)
                  .HasForeignKey(vale => new { vale.IDCLIENTE })
                  .HasPrincipalKey(cliente => new { cliente.Id })
                   .OnDelete(DeleteBehavior.Cascade);

            builder
                  .HasMany(cliente => cliente.VendaTemporaria)
                  .WithOne(vendaTemp => vendaTemp.Cliente)
                  .HasForeignKey(vendaTemp => new { vendaTemp.IDCLIENTE })
                  .HasPrincipalKey(cliente => new { cliente.Id })
                   .OnDelete(DeleteBehavior.Cascade);

            builder
              .HasMany(cliente => cliente.Pedidos)
              .WithOne(pedido => pedido.Cliente)
              .HasForeignKey(vendaTemp => new { vendaTemp.IDCLIENTE })
              .HasPrincipalKey(cliente => new { cliente.Id })
               .OnDelete(DeleteBehavior.Cascade);

            builder
               .HasMany(cliente => cliente.Devolucao)
               .WithOne(devolucao => devolucao.Cliente)
               .HasForeignKey(devolucao => new { devolucao.IDCLIENTE })
               .HasPrincipalKey(cliente => new { cliente.Id })
                .OnDelete(DeleteBehavior.Cascade);

            builder
              .HasMany(cliente => cliente.ContaReceber)
              .WithOne(contaReceber => contaReceber.Cliente)
              .HasForeignKey(contaReceber => new { contaReceber.IDCLIENTE })
              .HasPrincipalKey(cliente => new { cliente.Id })
               .OnDelete(DeleteBehavior.Cascade);

            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Ativo);
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);

        }
    }
}
