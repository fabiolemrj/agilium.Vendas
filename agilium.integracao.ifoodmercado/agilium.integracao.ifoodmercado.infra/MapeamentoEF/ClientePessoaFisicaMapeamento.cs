using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class ClientePessoaFisicaMapeamento : IEntityTypeConfiguration<ClientePessoaFisica>
    {
        public void Configure(EntityTypeBuilder<ClientePessoaFisica> builder)
        {
            builder.ToTable("clientepf");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("IDCLIENTE").HasColumnType("bigint").IsRequired();
            builder.Property(c => c.NURG).HasColumnName("NURG").HasColumnType("varchar(20)");   
            builder.Property(c => c.DTNASC).HasColumnName("DTNASC").HasColumnType("date");

            builder.OwnsOne(x => x.Cpf, cpf =>
            {
                cpf.Property(x => x.Cpf)
                    .HasColumnName("NUCPF")
                    .HasColumnType("varchar(15)");
            });

            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Ativo);
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);

        }
    }
}
