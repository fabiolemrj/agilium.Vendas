using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class LogErroMapeamento : IEntityTypeConfiguration<LogErro>
    {
        public void Configure(EntityTypeBuilder<LogErro> builder)
        {
            builder.ToTable("logerro");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("id_logerro").HasColumnType("bigint").IsRequired();

            builder.Property(c => c.usuario).HasColumnName("usuario").HasColumnType("varchar(50)");  
            builder.Property(c => c.erro).HasColumnName("erro").HasColumnType("text");  
            builder.Property(c => c.Tipo).HasColumnName("Tipo").HasColumnType("varchar(100)");   
            builder.Property(c => c.Tela).HasColumnName("Tela").HasColumnType("varchar(50)");   
            builder.Property(c => c.Controle).HasColumnName("Controle").HasColumnType("varchar(50)");   
            builder.Property(c => c.Maquina).HasColumnName("Maquina").HasColumnType("varchar(50)");   
            builder.Property(c => c.Data_erro).HasColumnName("Data_erro").HasColumnType("date");  
            builder.Property(c => c.Hora_erro).HasColumnName("Hora_erro").HasColumnType("varchar(10)");   
            builder.Property(c => c.SQL_erro).HasColumnName("SQL_erro").HasColumnType("text");

            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Ativo);
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);
        }
    }
}
