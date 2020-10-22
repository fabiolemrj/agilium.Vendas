using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class PedidoPagamento: Entidade
    {
        public Int64? IDPEDIDO { get; private set; }
        public virtual Pedido Pedido { get; private set; }
        public Int64? IDFORMAPAG { get; private set; }
        public virtual FormaPagamento FormaPagamento { get; private set; }
        public Int64? IDMOEDA { get; private set; }
        public virtual Moeda Moeda { get; private set; }
        public double? VLPAG { get; private set; }
        public string DSOBSPAG { get; private set; }


        private PedidoPagamento()
        {

        }
    }
}
