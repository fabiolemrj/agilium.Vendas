using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class CompraFiscal: Entidade
    {
        public Int64? IDCOMPRA { get; private set; }
        public virtual Compra Compra { get; private set; }
        public int? STMANIFESTO { get; private set; }
        public string DSXML { get; private set; }
        private CompraFiscal()
        {

        }
    }
}
