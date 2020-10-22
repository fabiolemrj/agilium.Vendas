using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class VendaTemporariaEspelho: Entidade
    {
        public Int64? IDVENDA { get; private set; }
        public virtual VendaTemporaria Venda { get; private set; }
        public string DSESPELHO { get; private set; }
        private VendaTemporariaEspelho()
        {

        }

    }
}
