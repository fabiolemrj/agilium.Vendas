using agilium.integracao.ifoodmercado.dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.MapeamentoEF
{
    public class ValorCodigoMapeamento : IEntityTypeConfiguration<ValorCodigo>
    {
        public void Configure(EntityTypeBuilder<ValorCodigo> builder)
        {

            builder.ToTable("countCodigoGenerico");
            builder.HasKey(c => c.Tabela);
        }


    }
}
