using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class EmpresaMySqlMapeamento : IEntityTypeConfiguration<EmpresaMysql>
    {
        public void Configure(EntityTypeBuilder<EmpresaMysql> builder)
        {
            builder.ToTable("empresa");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("IDEMPRESA").HasColumnType("bigint").IsRequired();
            builder.Property(c => c.IDENDERECO).HasColumnName("IDENDERECO").HasColumnType("bigint");  
            builder.Property(c => c.CDEMPRESA).HasColumnName("CDEMPRESA").HasColumnType("varchar(6)");  
            builder.Property(c => c.NMRZSOCIAL).HasColumnName("NMRZSOCIAL").HasColumnType("varchar(70)");   
            builder.Property(c => c.NMFANTASIA).HasColumnName("NMFANTASIA").HasColumnType("varchar(70)");   
           // builder.Property(c => c.NUCNPJ).HasColumnName("NUCNPJ").HasColumnType("varchar(20)");   
            builder.Property(c => c.DSINSCREST).HasColumnName("DSINSCREST").HasColumnType("varchar(20)");   
            builder.Property(c => c.DSINSCRESTVINC).HasColumnName("DSINSCRESTVINC").HasColumnType("varchar(20)");   
            builder.Property(c => c.DSINSCRMUN).HasColumnName("DSINSCRMUN").HasColumnType("varchar(20)");   
            builder.Property(c => c.NMDISTRIBUIDORA).HasColumnName("NMDISTRIBUIDORA").HasColumnType("varchar(50)");   
            builder.Property(c => c.NUREGJUNTACOM).HasColumnName("NUREGJUNTACOM").HasColumnType("varchar(20)");   
            builder.Property(c => c.NUCAPARM).HasColumnName("NUCAPARM").HasColumnType("decimal(10,3)");  
            builder.Property(c => c.STMICROEMPRESA).HasColumnName("STMICROEMPRESA").HasColumnType("int");  
            builder.Property(c => c.STLUCROPRESUMIDO).HasColumnName("STLUCROPRESUMIDO").HasColumnType("int");  
            builder.Property(c => c.TPEMPRESA).HasColumnName("TPEMPRESA").HasColumnType("int");  
            builder.Property(c => c.CRT).HasColumnName("CRT").HasColumnType("int");  
            builder.Property(c => c.IDCSC).HasColumnName("IDCSC").HasColumnType("varchar(10)");  
            builder.Property(c => c.CSC).HasColumnName("CSC").HasColumnType("varchar(40)");   
            builder.Property(c => c.NUCNAE).HasColumnName("NUCNAE").HasColumnType("varchar(10)");

            builder.OwnsOne(x => x.Cnpj, cnpj =>
            {
                cnpj.Property(x => x.Cnpj)
                    .HasColumnName("NUCNPJ")
                    .HasColumnType("varchar(20)");
            });

            //chaves estrangeiras
            builder
                .HasMany(empresa => empresa.GruposProdutos)
                .WithOne(grupo => grupo.Empresa)
                .HasForeignKey(grupo => new { grupo.idEmpresa })
                .HasPrincipalKey(empresa => new { empresa.Id })
                 .OnDelete(DeleteBehavior.Cascade);

             builder
               .HasMany(empresa => empresa.Produtos)
               .WithOne(prod => prod.Empresa)
               .HasForeignKey(prod => new { prod.idEmpresa })
               .HasPrincipalKey(empresa => new { empresa.Id })
                .OnDelete(DeleteBehavior.Cascade);

            builder
              .HasMany(empresa => empresa.Estoque)
              .WithOne(estoque => estoque.Empresa)
              .HasForeignKey(estoque => new { estoque.idEmpresa })
              .HasPrincipalKey(empresa => new { empresa.Id })
               .OnDelete(DeleteBehavior.Cascade);

            builder
            .HasMany(empresa => empresa.ContatoEmpresas)
            .WithOne(contato => contato.Empresa)
            .HasForeignKey(contato => new { contato.IDEMPRESA })
            .HasPrincipalKey(empresa => new { empresa.Id })
             .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasMany(empresa => empresa.PontoVenda)
                .WithOne(pontoVenda => pontoVenda.Empresa)
                .HasForeignKey(pontoVenda => new { pontoVenda.IDEMPRESA })
                .HasPrincipalKey(empresa => new { empresa.Id })
                    .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasMany(empresa => empresa.Caixas)
                .WithOne(caixa => caixa.Empresa)
                .HasForeignKey(caixa => new { caixa.IDEMPRESA })
                .HasPrincipalKey(empresa => new { empresa.Id })
                    .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasMany(empresa => empresa.Moedas)
                .WithOne(moeda => moeda.Empresa)
                .HasForeignKey(moeda => new { moeda.IDEMPRESA })
                .HasPrincipalKey(empresa => new { empresa.Id })
                    .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasMany(empresa => empresa.FormaPagamentos)
                .WithOne(formaPagamento => formaPagamento.Empresa)
                .HasForeignKey(formaPagamento => new { formaPagamento.IDEMPRESA })
                .HasPrincipalKey(empresa => new { empresa.Id })
                    .OnDelete(DeleteBehavior.Cascade);

            builder
              .HasMany(empresa => empresa.Vales)
              .WithOne(vale => vale.Empresa)
              .HasForeignKey(vale => new { vale.IDEMPRESA })
              .HasPrincipalKey(empresa => new { empresa.Id })
                  .OnDelete(DeleteBehavior.Cascade);

            builder
              .HasMany(empresa => empresa.Turnos)
              .WithOne(turno => turno.Empresa)
              .HasForeignKey(turno => new { turno.IDEMPRESA })
              .HasPrincipalKey(empresa => new { empresa.Id })
                  .OnDelete(DeleteBehavior.Cascade);
            builder
              .HasMany(empresa => empresa.Sequencials)
              .WithOne(seq => seq.Empresa)
              .HasForeignKey(seq => new { seq.IDEMPRESA })
              .HasPrincipalKey(empresa => new { empresa.Id })
                  .OnDelete(DeleteBehavior.Cascade);

            builder
              .HasMany(empresa => empresa.EmpresaAutorizacao)
              .WithOne(aut => aut.Empresa)
              .HasForeignKey(aut => new { aut.IDEMPRESA })
              .HasPrincipalKey(empresa => new { empresa.Id })
                  .OnDelete(DeleteBehavior.Cascade);

            builder
              .HasMany(empresa => empresa.Funcionarios)
              .WithOne(func => func.Empresa)
              .HasForeignKey(func => new { func.IDEMPRESA })
              .HasPrincipalKey(empresa => new { empresa.Id })
                  .OnDelete(DeleteBehavior.Cascade);

            builder
              .HasMany(empresa => empresa.Pedidos)
              .WithOne(pedido => pedido.Empresa)
              .HasForeignKey(pedido => new { pedido.IDEMPRESA })
              .HasPrincipalKey(empresa => new { empresa.Id })
                  .OnDelete(DeleteBehavior.Cascade);

            builder
               .HasMany(empresa => empresa.Perdas)
               .WithOne(perda => perda.Empresa)
               .HasForeignKey(perda => new { perda.IDEMPRESA })
               .HasPrincipalKey(empresa => new { empresa.Id })
                   .OnDelete(DeleteBehavior.Cascade);

            builder
               .HasMany(empresa => empresa.PlanoConta)
               .WithOne(planoconta => planoconta.Empresa)
               .HasForeignKey(planoconta => new { planoconta.IDEMPRESA })
               .HasPrincipalKey(empresa => new { empresa.Id })
                   .OnDelete(DeleteBehavior.Cascade);

            builder
               .HasMany(empresa => empresa.NotaFiscalInutil)
               .WithOne(notafiscalinutil => notafiscalinutil.Empresa)
               .HasForeignKey(notafiscalinutil => new { notafiscalinutil.IDEMPRESA })
               .HasPrincipalKey(empresa => new { empresa.Id })
                   .OnDelete(DeleteBehavior.Cascade);

            builder
               .HasMany(empresa => empresa.MotivoDevolucao)
               .WithOne(motivodevol => motivodevol.Empresa)
               .HasForeignKey(motivodevol => new { motivodevol.IDEMPRESA })
               .HasPrincipalKey(empresa => new { empresa.Id })
                   .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasMany(empresa => empresa.Inventarios)
                .WithOne(inventario => inventario.Empresa)
                .HasForeignKey(inventario => new { inventario.IDEMPRESA })
                .HasPrincipalKey(empresa => new { empresa.Id })
                    .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasMany(empresa => empresa.Licenca)
                .WithOne(licenca => licenca.Empresa)
                .HasForeignKey(licenca => new { licenca.IDEMPRESA })
                .HasPrincipalKey(empresa => new { empresa.Id })
                    .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasMany(empresa => empresa.Devolucao)
                .WithOne(devolucao => devolucao.Empresa)
                .HasForeignKey(devolucao => new { devolucao.IDEMPRESA })
                .HasPrincipalKey(empresa => new { empresa.Id })
                    .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasMany(empresa => empresa.ContaReceber)
                .WithOne(contaReceber => contaReceber.Empresa)
                .HasForeignKey(contaReceber => new { contaReceber.IDEMPRESA })
                .HasPrincipalKey(empresa => new { empresa.Id })
                    .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasMany(empresa => empresa.ContaPagar)
                .WithOne(contaPagar => contaPagar.Empresa)
                .HasForeignKey(contaPagar => new { contaPagar.IDEMPRESA })
                .HasPrincipalKey(empresa => new { empresa.Id })
                    .OnDelete(DeleteBehavior.Cascade);

            builder
                 .HasMany(empresa => empresa.Configuracao)
                 .WithOne(config => config.Empresa)
                 .HasForeignKey(config => new { config.IDEMPRESA })
                 .HasPrincipalKey(empresa => new { empresa.Id })
                     .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasMany(empresa => empresa.ConfiguracaoCertificado)
                .WithOne(configCert => configCert.Empresa)
                .HasForeignKey(configCert => new { configCert.IDEMPRESA })
                .HasPrincipalKey(empresa => new { empresa.Id })
                    .OnDelete(DeleteBehavior.Cascade);

            builder
               .HasMany(empresa => empresa.ConfiguracaoImagem)
               .WithOne(configImagem => configImagem.Empresa)
               .HasForeignKey(configImagem => new { configImagem.IDEMPRESA })
               .HasPrincipalKey(empresa => new { empresa.Id })
                   .OnDelete(DeleteBehavior.Cascade);

            builder
               .HasMany(empresa => empresa.Compra)
               .WithOne(compra => compra.Empresa)
               .HasForeignKey(compra => new { compra.IDEMPRESA })
               .HasPrincipalKey(empresa => new { empresa.Id })
                   .OnDelete(DeleteBehavior.Cascade);

            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Ativo);
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);
            //builder.Ignore( c => c.Id);


        }
    }
}
