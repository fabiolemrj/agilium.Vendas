using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class UsuarioMapeamento : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("ca_usuarios");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("id_usuario").HasColumnType("bigint").IsRequired();
             
            builder.Property(c => c.nome).HasColumnName("nome").HasColumnType("varchar(50)");  
            builder.Property(c => c.cpf).HasColumnName("cpf").HasColumnType("varchar(14)");   
            builder.Property(c => c.ender).HasColumnName("ender").HasColumnType("varchar(60)");   
            builder.Property(c => c.num).HasColumnName("num").HasColumnType("int");  
            builder.Property(c => c.compl).HasColumnName("compl").HasColumnType("varchar(35)");  
            builder.Property(c => c.bairro).HasColumnName("bairro").HasColumnType("varchar(40)");   
            builder.Property(c => c.cep).HasColumnName("cep").HasColumnType("varchar(9)");   
            builder.Property(c => c.cidade).HasColumnName("cidade").HasColumnType("varchar(40)");   
            builder.Property(c => c.uf).HasColumnName("uf").HasColumnType("varchar(2)");   
            builder.Property(c => c.tel1).HasColumnName("tel1").HasColumnType("varchar(14)");   
            builder.Property(c => c.cel).HasColumnName("cel").HasColumnType("varchar(14)");   
            builder.Property(c => c.dtnasc).HasColumnName("dtnasc").HasColumnType("date");  
            builder.Property(c => c.usuario).HasColumnName("usuario").HasColumnType("varchar(20)");   
            builder.Property(c => c.senha).HasColumnName("senha").HasColumnType("varchar(40)");   
            builder.Property(c => c.email).HasColumnName("email").HasColumnType("varchar(100)");   
            builder.Property(c => c.foto).HasColumnName("foto").HasColumnType("varchar(100)");   
            builder.Property(c => c.tel2).HasColumnName("tel2").HasColumnType("varchar(14)");  
            builder.Property(c => c.ativo).HasColumnName("ativo").HasColumnType("varchar(1)");   
            builder.Property(c => c.dtcad).HasColumnName("dtcad").HasColumnType("date");  
            builder.Property(c => c.id_perfil).HasColumnName("id_perfil").HasColumnType("int");

            //chaves estrangeiras
            builder
                .HasMany(usuario => usuario.CaixaMoedas)
                .WithOne(caixaMoeda => caixaMoeda.UsuarioCorrecao)
                .HasForeignKey(caixaMoeda => new { caixaMoeda.IDUSUARIOCORRECAO })
                .HasPrincipalKey(usuario => new { usuario.Id })
                 .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasMany(usuario => usuario.TurnoInicial)
                .WithOne(turnoInicio => turnoInicio.UsuarioInicial)
                .HasForeignKey(turnoInicio => new { turnoInicio.IDUSUARIOINI })
                .HasPrincipalKey(usuario => new { usuario.Id })
                 .OnDelete(DeleteBehavior.Cascade);

            builder
               .HasMany(usuario => usuario.TurnoFinal)
               .WithOne(turnoInicio => turnoInicio.UsuarioFinal)
               .HasForeignKey(turnoInicio => new { turnoInicio.IDUSUARIOFIM })
               .HasPrincipalKey(usuario => new { usuario.Id })
                .OnDelete(DeleteBehavior.Cascade);

            builder
               .HasMany(usuario => usuario.VendaCancelada)
               .WithOne(vendaCancel => vendaCancel.UsuarioCancelamento)
               .HasForeignKey(vendaCancel => new { vendaCancel.IDUSUARIOCANCEL })
               .HasPrincipalKey(usuario => new { usuario.Id })
                .OnDelete(DeleteBehavior.Cascade);

            builder
               .HasMany(usuario => usuario.EmpresaAutorizacao)
               .WithOne(aut => aut.Usuario)
               .HasForeignKey(aut => new { aut.IDUSUARIO })
               .HasPrincipalKey(usuario => new { usuario.Id })
                .OnDelete(DeleteBehavior.Cascade);

            builder
                 .HasMany(usuario => usuario.Funcionarios)
                 .WithOne(func => func.Usuario)
                 .HasForeignKey(func => new { func.IDUSUARIO })
                 .HasPrincipalKey(usuario => new { usuario.Id })
                  .OnDelete(DeleteBehavior.Cascade);

            builder
               .HasMany(usuario => usuario.Perdas)
               .WithOne(perda => perda.Usuario)
               .HasForeignKey(perda => new { perda.IDUSUARIO })
               .HasPrincipalKey(usuario => new { usuario.Id })
                .OnDelete(DeleteBehavior.Cascade);

            builder
               .HasMany(usuario => usuario.InventarioItem)
               .WithOne(inventarioItem => inventarioItem.UsuarioAnalise)
               .HasForeignKey(inventarioItem => new { inventarioItem.IDUSUARIOANALISE })
               .HasPrincipalKey(usuario => new { usuario.Id })
                .OnDelete(DeleteBehavior.Cascade);

            builder
             .HasMany(usuario => usuario.ContaReceber)
             .WithOne(contaReceber => contaReceber.Usuario)
             .HasForeignKey(contaReceber => new { contaReceber.IDUSUARIO })
             .HasPrincipalKey(usuario => new { usuario.Id })
              .OnDelete(DeleteBehavior.Cascade);

            builder
               .HasMany(usuario => usuario.ContaPagar)
               .WithOne(contaPagar => contaPagar.Usuario)
               .HasForeignKey(contaPagar => new { contaPagar.IDUSUARIO })
               .HasPrincipalKey(usuario => new { usuario.Id })
                .OnDelete(DeleteBehavior.Cascade);

            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Ativo);
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);
        }
    }
}
