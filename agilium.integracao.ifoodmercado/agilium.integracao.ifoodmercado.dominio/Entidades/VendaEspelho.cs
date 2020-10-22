using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class VendaEspelho: Entidade
    {
        public Int64? IDVENDA { get; private set; }
        public virtual Venda Venda { get; private set; }
        public string DSESPELHO { get; private set; }
        private VendaEspelho()
        {

        }
    }
}
