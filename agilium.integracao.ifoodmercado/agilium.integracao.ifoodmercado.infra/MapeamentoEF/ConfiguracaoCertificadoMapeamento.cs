using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class ConfiguracaoCertificadoMapeamento : IEntityTypeConfiguration<ConfiguracaoCertificado>
    {
        public void Configure(EntityTypeBuilder<ConfiguracaoCertificado> builder)
        {
            builder.ToTable("config_certif");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("IDCONFIGCERTIF").HasColumnType("bigint").IsRequired();

            builder.Property(c => c.IDEMPRESA).HasColumnName("IDEMPRESA").HasColumnType("bigint");  
            builder.Property(c => c.NMMAQUINA).HasColumnName("NMMAQUINA").HasColumnType("varchar(100)");  
            builder.Property(c => c.DSCAMINHO).HasColumnName("DSCAMINHO").HasColumnType("varchar(400)");   
            builder.Property(c => c.DSSENHA).HasColumnName("DSSENHA").HasColumnType("varchar(50)");


            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Ativo);
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);
        }
    }
}
