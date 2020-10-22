using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class PedidoVenda: Entidade
    {
        public Int64? IDPEDIDO { get; private set; }
        public virtual Pedido Pedido { get; private set; }
        public Int64? IDVENDA { get; private set; }
        public virtual Venda Venda { get; private set; }

        private PedidoVenda()
        {

        }
    }
}
