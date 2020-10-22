using agilium.integracao.ifoodmercado.dominio.Entidades;
using agilium.integracao.ifoodmercado.dominio.Interfaces.Repositorios;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class CestNcmMapeamento : IEntityTypeConfiguration<CestNcm>
    {
        public void Configure(EntityTypeBuilder<CestNcm> builder)
        {
            builder.ToTable("cest_ncm");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("IDCEST_NCM").HasColumnType("bigint").IsRequired();   
            builder.Property(c => c.CDCEST).HasColumnName("CDCEST").HasColumnType("varchar(15)");  
            builder.Property(c => c.CDNCM).HasColumnName("CDNCM").HasColumnType("varchar(15)");   
            builder.Property(c => c.DSDESCR).HasColumnName("DSDESCR").HasColumnType("varchar(600)");

            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Ativo);
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);
        }
    }
}
