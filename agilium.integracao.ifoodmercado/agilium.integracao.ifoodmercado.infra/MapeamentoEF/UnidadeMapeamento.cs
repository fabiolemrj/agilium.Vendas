using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class UnidadeMapeamento : IEntityTypeConfiguration<Unidade>
    {
        public void Configure(EntityTypeBuilder<Unidade> builder)
        {
            builder.ToTable("unidade");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("IDUNIDADE").HasColumnType("bigint").IsRequired();
             
            builder.Property(c => c.NMSIGLA).HasColumnName("NMSIGLA").HasColumnType("varchar(5)");  
            builder.Property(c => c.DSSIGLA).HasColumnName("DSSIGLA").HasColumnType("varchar(30)");   
            builder.Property(c => c.STATIVO).HasColumnName("STATIVO").HasColumnType("int");

            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Ativo);
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);
        }
    }
}
