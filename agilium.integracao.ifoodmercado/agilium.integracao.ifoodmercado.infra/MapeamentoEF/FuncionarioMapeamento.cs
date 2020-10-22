using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class FuncionarioMapeamento : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.ToTable("funcionario");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("IDFUNC").HasColumnType("bigint").IsRequired();

             builder.Property(c => c.IDUSUARIO).HasColumnName("IDUSUARIO").HasColumnType("bigint");  
             builder.Property(c => c.IDENDERECO).HasColumnName("IDENDERECO").HasColumnType("bigint");  
             builder.Property(c => c.IDEMPRESA).HasColumnName("IDEMPRESA").HasColumnType("bigint");  
             builder.Property(c => c.CDFUNC).HasColumnName("CDFUNC").HasColumnType("varchar(6)");  
             builder.Property(c => c.NMFUNC).HasColumnName("NMFUNC").HasColumnType("varchar(50)");   
             builder.Property(c => c.NUTURNO).HasColumnName("NUTURNO").HasColumnType("int");  
             builder.Property(c => c.STFUNC).HasColumnName("STFUNC").HasColumnType("int");  
             builder.Property(c => c.NUCPF).HasColumnName("NUCPF").HasColumnType("varchar(15)");  
             builder.Property(c => c.NURG).HasColumnName("NURG").HasColumnType("varchar(20)");   
             builder.Property(c => c.DTADM).HasColumnName("DTADM").HasColumnType("datetime");  
             builder.Property(c => c.DTDEM).HasColumnName("DTDEM").HasColumnType("datetime");  
             builder.Property(c => c.DSRFID).HasColumnName("DSRFID").HasColumnType("varchar(50)");   
             builder.Property(c => c.STNOTURNO).HasColumnName("STNOTURNO").HasColumnType("int");

            //chaves estrangeiras

            builder
              .HasMany(func => func.Pedidos)
              .WithOne(pedido => pedido.Funcionario)
              .HasForeignKey(pedido => new { pedido.IDFUNC })
              .HasPrincipalKey(func => new { func.Id })
               .OnDelete(DeleteBehavior.Cascade);

            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Ativo);
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);
        }
    }
}
