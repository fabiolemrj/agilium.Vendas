using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class ContatoMapeamento : IEntityTypeConfiguration<Contato>
    {
        public void Configure(EntityTypeBuilder<Contato> builder)
        {
            builder.ToTable("contato");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("IDCONTATO").HasColumnType("bigint").IsRequired();
            builder.Property(c => c.TPCONTATO).HasColumnName("TPCONTATO").HasColumnType("int").IsRequired();               
            builder.Property(c => c.DESCR1).HasColumnName("DESCR1").HasColumnType("varchar(100)");
            builder.Property(c => c.DESCR2).HasColumnName("DESCR2").HasColumnType("varchar(100)");

            builder
               .HasMany(contato => contato.ContatoEmpresas)
               .WithOne(contatoEmpresa => contatoEmpresa.Contato)
               .HasForeignKey(contatoEmpresa => new { contatoEmpresa.IDCONTATO })
               .HasPrincipalKey(contato => new { contato.Id })
                .OnDelete(DeleteBehavior.Cascade);

            builder
               .HasMany(contato => contato.ClienteContatos)
               .WithOne(clienteCont => clienteCont.Contato)
               .HasForeignKey(clienteCont => new { clienteCont.IDCONTATO })
               .HasPrincipalKey(contato => new { contato.Id })
                .OnDelete(DeleteBehavior.Cascade);


            builder
               .HasMany(contato => contato.FornecedorContato)
               .WithOne(fornec => fornec.Contato)
               .HasForeignKey(fornec => new { fornec.IDCONTATO })
               .HasPrincipalKey(contato => new { contato.Id })
                .OnDelete(DeleteBehavior.Cascade);

            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Ativo);
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);
        }
    }
}
