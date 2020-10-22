using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class DevolucaoMapeamento : IEntityTypeConfiguration<Devolucao>
    {
        public void Configure(EntityTypeBuilder<Devolucao> builder)
        {
            builder.ToTable("devolucao");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).HasColumnName("IDDEV").HasColumnType("bigint").IsRequired();

            builder.Property(c => c.IDEMPRESA).HasColumnName("IDEMPRESA").HasColumnType("bigint");  
            builder.Property(c => c.IDVENDA).HasColumnName("IDVENDA").HasColumnType("bigint");  
            builder.Property(c => c.IDCLIENTE).HasColumnName("IDCLIENTE").HasColumnType("bigint");  
            builder.Property(c => c.IDMOTDEV).HasColumnName("IDMOTDEV").HasColumnType("bigint");  
            builder.Property(c => c.IDVALE).HasColumnName("IDVALE").HasColumnType("bigint");  
            builder.Property(c => c.CDDEV).HasColumnName("CDDEV").HasColumnType("varchar(6)");  
            builder.Property(c => c.DTHRDEV).HasColumnName("DTHRDEV").HasColumnType("datetime");  
            builder.Property(c => c.VLTOTALDEV).HasColumnName("VLTOTALDEV").HasColumnType("double");  
            builder.Property(c => c.DSOBSDEV).HasColumnName("DSOBSDEV").HasColumnType("varchar(200)");  
            builder.Property(c => c.STDEV).HasColumnName("STDEV").HasColumnType("int");

            //chaves estrangeiras
            builder
             .HasMany(devolucao => devolucao.DevolucaoItem)
             .WithOne(devolucaoItem => devolucaoItem.Devolucao)
             .HasForeignKey(devolucaoItem => new { devolucaoItem.IDDEV })
             .HasPrincipalKey(devolucao => new { devolucao.Id })
             .OnDelete(DeleteBehavior.Cascade);

            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Ativo);
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);
        }
    }
}
