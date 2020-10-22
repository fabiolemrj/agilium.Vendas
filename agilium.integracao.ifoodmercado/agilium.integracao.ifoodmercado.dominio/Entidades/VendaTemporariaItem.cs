using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class VendaTemporariaItem: Entidade
    {
        public Int64? IDVENDA { get; private set; }
        public virtual VendaTemporaria Venda { get; private set; }
        public Int64? IDPRODUTO { get; private set; }
        public virtual Produto Produto { get; private set; }
        public int? SQITEM { get; private set; }
        public double? VLUNIT { get; private set; }
        public double? NUQTD { get; private set; }
        public double? VLITEM { get; private set; }
        public double? VLACRES { get; private set; }
        public double? VLDESC { get; private set; }
        public double? VLTOTAL { get; private set; }
        public double? VLCUSTOMEDIO { get; private set; }
        public int? STITEM { get; private set; }
        public double? PCIBPTFED { get; private set; }
        public double? PCIBPTEST { get; private set; }
        public double? PCIBPTMUN { get; private set; }
        public double? PCIBPTIMP { get; private set; }
        private VendaTemporariaItem()
        {

        }
    }
}
