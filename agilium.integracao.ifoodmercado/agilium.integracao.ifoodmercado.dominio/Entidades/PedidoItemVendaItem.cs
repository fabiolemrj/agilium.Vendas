using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class PedidoItemVendaItem: Entidade
    {
        public Int64? IDITEMPEDIDO { get; private set; }
        public virtual PedidoItem PedidoItem { get; private set; }
        public Int64? IDVENDA_ITEM { get; private set; }
        public virtual VendaItem VendaItem { get; private set; }
        private PedidoItemVendaItem()
        {

        }
    }
}
