using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class LogSistemaMapeamento : IEntityTypeConfiguration<LogSistema>
    {
        public void Configure(EntityTypeBuilder<LogSistema> builder)
        {
            builder.ToTable("log_sist");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("id_log").HasColumnType("bigint").IsRequired();  
            builder.Property(c => c.usuario).HasColumnName("usuario").HasColumnType("varchar(50)");  
            builder.Property(c => c.descr).HasColumnName("descr").HasColumnType("text");  
            builder.Property(c => c.tela).HasColumnName("tela").HasColumnType("varchar(50)");  
            builder.Property(c => c.controle).HasColumnName("controle").HasColumnType("varchar(50)");  
            builder.Property(c => c.maquina).HasColumnName("maquina").HasColumnType("varchar(50)");   
            builder.Property(c => c.data_log).HasColumnName("data_log").HasColumnType("date");  
            builder.Property(c => c.hora_log).HasColumnName("hora_log").HasColumnType("varchar(10)");   
            builder.Property(c => c.SQL_log).HasColumnName("SQL_log").HasColumnType("text");  
            builder.Property(c => c.so).HasColumnName("so").HasColumnType("varchar(255)");


            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Ativo);
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);
        }
    }
}
