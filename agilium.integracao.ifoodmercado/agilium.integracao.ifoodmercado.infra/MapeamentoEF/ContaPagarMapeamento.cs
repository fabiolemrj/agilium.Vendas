﻿using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class ContaPagarMapeamento : IEntityTypeConfiguration<ContaPagar>
    {
        public void Configure(EntityTypeBuilder<ContaPagar> builder)
        {
            builder.ToTable("contas_pagar");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("IDCONTAPAG").HasColumnType("bigint").IsRequired();

            builder.Property(c => c.IDCONTAPAI).HasColumnName("IDCONTAPAI").HasColumnType("bigint");  
            builder.Property(c => c.IDCATEG_FINANC).HasColumnName("IDCATEG_FINANC").HasColumnType("bigint");  
            builder.Property(c => c.IDUSUARIO).HasColumnName("IDUSUARIO").HasColumnType("bigint");  
            builder.Property(c => c.IDFORNEC).HasColumnName("IDFORNEC").HasColumnType("bigint");  
            builder.Property(c => c.IDCONTA).HasColumnName("IDCONTA").HasColumnType("bigint"); 
            builder.Property(c => c.IDEMPRESA).HasColumnName("IDEMPRESA").HasColumnType("bigint");  
            builder.Property(c => c.IDLANC).HasColumnName("IDLANC").HasColumnType("bigint");  
            builder.Property(c => c.DESCR).HasColumnName("DESCR").HasColumnType("varchar(100)"); 
            builder.Property(c => c.DTVENC).HasColumnName("DTVENC").HasColumnType("date");  
            builder.Property(c => c.DTPAG).HasColumnName("DTPAG").HasColumnType("date");  
            builder.Property(c => c.VLCONTA).HasColumnName("VLCONTA").HasColumnType("double");  
            builder.Property(c => c.VLDESC).HasColumnName("VLDESC").HasColumnType("double");  
            builder.Property(c => c.VLACRESC).HasColumnName("VLACRESC").HasColumnType("double");  
            builder.Property(c => c.PARCINI).HasColumnName("PARCINI").HasColumnType("int");  
            builder.Property(c => c.TPCONTA).HasColumnName("TPCONTA").HasColumnType("int");  
            builder.Property(c => c.STCONTA).HasColumnName("STCONTA").HasColumnType("int");  
            builder.Property(c => c.OBS).HasColumnName("OBS").HasColumnType("varchar(255)");  
            builder.Property(c => c.NUMNF).HasColumnName("NUMNF").HasColumnType("varchar(45)");   
            builder.Property(c => c.DTNF).HasColumnName("DTNF").HasColumnType("date");  
            builder.Property(c => c.DTCAD).HasColumnName("DTCAD").HasColumnType("date");

            //chaves estrangeiras
            builder
             .HasMany(contaPagar => contaPagar.ContaPagarPai)
             .WithOne(contaPagarPai => contaPagarPai.ContaPagaPai)
             .HasForeignKey(contaPagarPai => new { contaPagarPai.IDCONTAPAI })
             .HasPrincipalKey(contaPagar => new { contaPagar.Id })
             .OnDelete(DeleteBehavior.Cascade);

            //campos padrao da entidade que nao existem na tabela
            builder.Ignore(c => c.Ativo);
            builder.Ignore(c => c.Codigo);
            builder.Ignore(c => c.DataCadastro);
            builder.Ignore(c => c.DataUltimaAtualizacao);
        }
    }
}
