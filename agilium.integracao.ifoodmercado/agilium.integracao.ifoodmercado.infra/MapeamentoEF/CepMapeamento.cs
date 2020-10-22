using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class CepMapeamento : IEntityTypeConfiguration<Cep>
    {
        public void Configure(EntityTypeBuilder<Cep> builder)
        {
            builder.ToTable("ceps");
            builder.HasKey(c => c.id_logradouro);

            builder.Property(c => c.id_logradouro).HasColumnName("id_logradouro").HasColumnType("int").IsRequired();
        
            builder.Property(c => c.id_cidade).HasColumnName("id_cidade").HasColumnType("int").IsRequired();  
            builder.Property(c => c.cep).HasColumnName("cep").HasColumnType("varchar(8))").IsRequired();  
            builder.Property(c => c.uf).HasColumnName("uf").HasColumnType("varchar(2)").IsRequired();   
            builder.Property(c => c.ender).HasColumnName("ender").HasColumnType("varchar(90)");   
            builder.Property(c => c.cidade).HasColumnName("cidade").HasColumnType("varchar(65)");   
            builder.Property(c => c.bairro).HasColumnName("bairro").HasColumnType("varchar(75)");   
            builder.Property(c => c.ibge).HasColumnName("ibge").HasColumnType("int");
            builder.Property(c => c.tipo).HasColumnName("tipo").HasColumnType("varchar(20)");  
            
            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Ativo);
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);
            builder.Ignore(c => c.Id);
        }
    }
}
