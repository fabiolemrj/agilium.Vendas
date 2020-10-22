using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class AjudaMapeamento : IEntityTypeConfiguration<Ajuda>
    {
        public void Configure(EntityTypeBuilder<Ajuda> builder)
        {
            builder.ToTable("ajuda");
            builder.HasKey(c => c.idajuda);

            builder.Property(c => c.idajuda).HasColumnName("idajuda").HasColumnType("int").IsRequired();
            builder.Property(c => c.titulo).HasColumnName("titulo").HasColumnType("varchar(200)");  
            builder.Property(c => c.palavras_chave).HasColumnName("palavras_chave").HasColumnType("varchar(200)");   
            builder.Property(c => c.conteudo).HasColumnName("conteudo").HasColumnType("longblob");

            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Ativo);
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);
            builder.Ignore(c => c.Id);
        }
    }
}
