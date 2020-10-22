using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class IbptMapeamento : IEntityTypeConfiguration<Ibpt>
    {
        public void Configure(EntityTypeBuilder<Ibpt> builder)
        {
            builder.ToTable("ibpt");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("IDIBPT").HasColumnType("bigint").IsRequired();

            builder.Property(c => c.NCM).HasColumnName("NCM").HasColumnType("varchar(20)");  
            builder.Property(c => c.EX).HasColumnName("EX").HasColumnType("int");  
            builder.Property(c => c.TIPO).HasColumnName("TIPO").HasColumnType("int");  
            builder.Property(c => c.DESCRICAO).HasColumnName("DESCRICAO").HasColumnType("varchar(255)");  
            builder.Property(c => c.NACIONALFEDERAL).HasColumnName("NACIONALFEDERAL").HasColumnType("double");  
            builder.Property(c => c.IMPORTADOSFEDERAL).HasColumnName("IMPORTADOSFEDERAL").HasColumnType("double");  
            builder.Property(c => c.ESTADUAL).HasColumnName("ESTADUAL").HasColumnType("double");  
            builder.Property(c => c.MUNICIPAL).HasColumnName("MUNICIPAL").HasColumnType("double");  
            builder.Property(c => c.INICIOVIG).HasColumnName("INICIOVIG").HasColumnType("date");  
            builder.Property(c => c.FIMVIG).HasColumnName("FIMVIG").HasColumnType("date");  
            builder.Property(c => c.VERSAO).HasColumnName("VERSAO").HasColumnType("varchar(10)");

            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Ativo);
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);
        }
    }
}
