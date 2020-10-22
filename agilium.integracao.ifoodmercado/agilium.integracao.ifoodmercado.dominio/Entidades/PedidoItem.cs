using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class PedidoItem: Entidade
    {
        public Int64? IDPEDIDO { get; private set; }
        public virtual Pedido Pedido { get; private set; }
        public Int64? IDPRODUTO { get; private set; }
        public virtual Produto Produto { get; private set; }
        public Int64? IDESTOQUE { get; private set; }
        public virtual Estoque Estoque { get; private set; }
        public Int64? IDFORN { get; private set; }
        public virtual Fornecedor Fornecedor { get; set; }
        public int? SQITEMPEDIDO { get; private set; }
        public double? VLUNIT { get; private set; }
        public double? NUQTD { get; private set; }
        public double? VLITEM { get; private set; }
        public double? VLACRES { get; private set; }
        public double? VLDESC { get; private set; }
        public double? VLOUTROS { get; private set; }
        public double? VLTOTAL { get; private set; }
        public double? VLCUSTOMEDIO { get; private set; }
        public int? STITEMPEDIDO { get; private set; }
        public DateTime? DTPREV_ENTREGA { get; private set; }
        public string DSOBSITEM { get; private set; }
        public virtual IReadOnlyCollection<PedidoItemVendaItem> PedidosItemVendaItem { get { return _pedidosItemVendaItem.ToList(); } }
        private IList<PedidoItemVendaItem> _pedidosItemVendaItem { get; set; }
        private PedidoItem()
        {
            _pedidosItemVendaItem = new List<PedidoItemVendaItem>();
        }
    }
}
