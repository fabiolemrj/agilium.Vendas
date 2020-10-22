using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class CaixaMovimentacaoMapeamento : IEntityTypeConfiguration<CaixaMovimentacao>
    {
        public void Configure(EntityTypeBuilder<CaixaMovimentacao> builder)
        {
            builder.ToTable("caixa_mov");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("IDCAIXA_MOV").HasColumnType("bigint").IsRequired();
            builder.Property(c => c.IDCAIXA).HasColumnName("IDCAIXA").HasColumnType("bigint");

            builder.Property(c => c.TPMOV).HasColumnName("TPMOV").HasColumnType("int");  
            builder.Property(c => c.DSMOV).HasColumnName("DSMOV").HasColumnType("varchar(50)");  
            builder.Property(c => c.VLMOV).HasColumnName("VLMOV").HasColumnType("double");  
            builder.Property(c => c.STMOV).HasColumnName("STMOV").HasColumnType("int");  

            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Ativo);
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);
        }
    }
}
