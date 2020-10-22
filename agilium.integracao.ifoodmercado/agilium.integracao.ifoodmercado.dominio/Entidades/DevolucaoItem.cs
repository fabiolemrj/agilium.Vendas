using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class DevolucaoItem: Entidade
    {
        public virtual Devolucao Devolucao { get; private set; }
        public Int64? IDDEV { get; private set; }
        public virtual VendaItem VendaItem { get; private set; }
        public Int64? IDVENDA_ITEM { get; private set; }
        public double? NUQTD { get; private set; }
        public double? VLITEM { get; private set; }
        private DevolucaoItem()
        {

        }
    }
}
