using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class VendaTemporariaMoeda: Entidade
    {
        public Int64? IDVENDA { get; private set; }
        public virtual VendaTemporaria Venda { get; private set; }
        public Int64? IDMOEDA { get; private set; }
        public virtual Moeda Moeda { get; private set; }
        public Int64? IDVALE { get; private set; }
        public double? VLPAGO { get; private set; }
        public double? VLTROCO { get; private set; }
        public int? NUPARCELAS { get; private set; }
        public string NSU { get; private set; }
        private VendaTemporariaMoeda()
        {

        }
    }
}
