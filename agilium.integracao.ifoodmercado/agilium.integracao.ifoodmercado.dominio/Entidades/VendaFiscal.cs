using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class VendaFiscal: Entidade
    {
        public Int64? IDVENDA { get; private set; }
        public virtual Venda Venda { get; private set; }
        public int? TPDOC { get; private set; }
        public string DSXML { get; private set; }
        public int? STDOCFISCAL { get; private set; }
        public DateTime? DTHREMISSAO { get; private set; }
        private VendaFiscal()
        {

        }
    }
}
