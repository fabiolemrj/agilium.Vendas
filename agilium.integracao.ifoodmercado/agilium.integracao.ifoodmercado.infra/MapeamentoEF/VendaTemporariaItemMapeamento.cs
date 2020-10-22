using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class VendaTemporariaItemMapeamento : IEntityTypeConfiguration<VendaTemporariaItem>
    {
        public void Configure(EntityTypeBuilder<VendaTemporariaItem> builder)
        {
            builder.ToTable("tmp_venda_item");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("IDVENDA_ITEM").HasColumnType("bigint").IsRequired();
            builder.Property(c => c.IDVENDA).HasColumnName("IDVENDA").HasColumnType("bigint");
            builder.Property(c => c.IDPRODUTO).HasColumnName("IDPRODUTO").HasColumnType("bigint");
            builder.Property(c => c.SQITEM).HasColumnName("SQITEM").HasColumnType("int");
            builder.Property(c => c.VLUNIT).HasColumnName("VLUNIT").HasColumnType("double");
            builder.Property(c => c.NUQTD).HasColumnName("NUQTD").HasColumnType("double");
            builder.Property(c => c.VLITEM).HasColumnName("VLITEM").HasColumnType("double");
            builder.Property(c => c.VLACRES).HasColumnName("VLACRES").HasColumnType("double");
            builder.Property(c => c.VLDESC).HasColumnName("VLDESC").HasColumnType("double");
            builder.Property(c => c.VLTOTAL).HasColumnName("VLTOTAL").HasColumnType("double");
            builder.Property(c => c.VLCUSTOMEDIO).HasColumnName("VLCUSTOMEDIO").HasColumnType("double");
            builder.Property(c => c.STITEM).HasColumnName("STITEM").HasColumnType("int");
            builder.Property(c => c.PCIBPTFED).HasColumnName("PCIBPTFED").HasColumnType("double");
            builder.Property(c => c.PCIBPTEST).HasColumnName("PCIBPTEST").HasColumnType("double");
            builder.Property(c => c.PCIBPTMUN).HasColumnName("PCIBPTMUN").HasColumnType("double");
            builder.Property(c => c.PCIBPTIMP).HasColumnName("PCIBPTIMP").HasColumnType("double");


            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Ativo);
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);
        }
    }
}
