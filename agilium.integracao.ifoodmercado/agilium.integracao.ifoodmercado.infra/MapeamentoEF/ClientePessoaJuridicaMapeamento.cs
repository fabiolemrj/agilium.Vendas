using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class ClientePessoaJuridicaMapeamento : IEntityTypeConfiguration<ClientePessoaJuridica>
    {
        public void Configure(EntityTypeBuilder<ClientePessoaJuridica> builder)
        {
            builder.ToTable("clientepj");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("IDCLIENTE").HasColumnType("bigint").IsRequired();

            builder.Property(c => c.NMRZSOCIAL).HasColumnName("NMRZSOCIAL").HasColumnType("varchar(70)");  
            builder.Property(c => c.DSINSCREST).HasColumnName("DSINSCREST").HasColumnType("varchar(20)");

            builder.OwnsOne(x => x.Cnpj, cnpj =>
            {
                cnpj.Property(x => x.Cnpj)
                    .HasColumnName("NUCNPJ")
                    .HasColumnType("varchar(20)");
            });
            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Ativo);
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);
        }
    }
}
