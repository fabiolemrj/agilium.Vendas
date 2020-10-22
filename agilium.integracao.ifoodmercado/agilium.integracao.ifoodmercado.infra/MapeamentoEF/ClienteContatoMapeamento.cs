using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class ClienteContatoMapeamento : IEntityTypeConfiguration<ClienteContato>
    {
        public void Configure(EntityTypeBuilder<ClienteContato> builder)
        {
            builder.ToTable("cli_contato");
            builder.HasKey(c => new { c.IDCLIENTE, c.IDCONTATO });

            builder.Property(c => c.IDCONTATO).HasColumnName("IDCONTATO").HasColumnType("bigint").IsRequired();
            builder.Property(c => c.IDCLIENTE).HasColumnName("IDCLIENTE").HasColumnType("bigint").IsRequired();


            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Id);
            builder.Ignore(c => c.Ativo);
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);
         
        }
    }
}
