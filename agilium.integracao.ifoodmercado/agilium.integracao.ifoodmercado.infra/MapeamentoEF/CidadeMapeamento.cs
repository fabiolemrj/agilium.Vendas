using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class CidadeMapeamento : IEntityTypeConfiguration<Cidade>
    {
        public void Configure(EntityTypeBuilder<Cidade> builder)
        {
            builder.ToTable("cidade");
            builder.HasKey(c => c.id_cidade);

             
            builder.Property(c => c.id_cidade).HasColumnName("id_cidade").HasColumnType("int").IsRequired();
            builder.Property(c => c.descricao).HasColumnName("descricao").HasColumnType("varchar(100)");  
            builder.Property(c => c.uf).HasColumnName("uf").HasColumnType("varchar(2)");   
            builder.Property(c => c.codigo_ibge).HasColumnName("codigo_ibge").HasColumnType("int");  
            builder.Property(c => c.ddd).HasColumnName("ddd").HasColumnType("varchar(2)");

            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Ativo);
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);
            builder.Ignore(c => c.Id);
        }
    }
}
