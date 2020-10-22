using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class VendaCancelada: Entidade
    {
        public Int64? IDVENDA { get; private set; }
        public virtual Venda Venda { get; private set; }
        public Int64? IDUSUARIOCANCEL { get; private set; }
        public virtual Usuario UsuarioCancelamento { get; private set; }
        public DateTime? DTHRCANCEL { get; private set; }
        public string DSMOTIVO { get; private set; }
        public string DSPROTOCOLO { get; private set; }
        public string DSXML { get; private set; }
        private VendaCancelada()
        {

        }
    }
}
