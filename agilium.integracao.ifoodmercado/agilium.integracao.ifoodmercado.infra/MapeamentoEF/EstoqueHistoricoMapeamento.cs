using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class EstoqueHistoricoMapeamento : IEntityTypeConfiguration<EstoqueHistorico>
    {
        public void Configure(EntityTypeBuilder<EstoqueHistorico> builder)
        {
            builder.ToTable("estoquehst");
            builder.HasKey(c => c.Id);
            //builder.HasAlternateKey(c => new { c.IDESTOQUE, c.IDPRODUTO, c.IDITEM, c.IDLANC});

            builder.Property(c => c.Id).HasColumnName("IDESTOQUEHST").HasColumnType("bigint").IsRequired();
            builder.Property(c => c.IDESTOQUE).HasColumnName("IDESTOQUE").HasColumnType("bigint");
            builder.Property(c => c.IDPRODUTO).HasColumnName("IDPRODUTO").HasColumnType("bigint");
            builder.Property(c => c.IDITEM).HasColumnName("IDITEM").HasColumnType("bigint");
            builder.Property(c => c.IDLANC).HasColumnName("IDLANC").HasColumnType("bigint");
            builder.Property(c => c.DTHRHST).HasColumnName("DTHRHST").HasColumnType("datetime");
            builder.Property(c => c.NMUSUARIO).HasColumnName("NMUSUARIO").HasColumnType("varchar(50)");
            builder.Property(c => c.TPHST).HasColumnName("TPHST").HasColumnType("int");
            builder.Property(c => c.DSHST).HasColumnName("DSHST").HasColumnType("varchar(250)");
            builder.Property(c => c.QTDHST).HasColumnName("QTDHST").HasColumnType(" double");

            //chave estrangeira
            builder
           .HasMany(estoqueHst => estoqueHst.Perdas)
           .WithOne(perda => perda.EstoqueHistorico)
           .HasForeignKey(perda => perda.IDESTOQUEHST)
           .HasPrincipalKey(estoqueHst => new { estoqueHst.Id })
            .OnDelete(DeleteBehavior.Cascade);

            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Ativo);
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);
        }
    }
}
