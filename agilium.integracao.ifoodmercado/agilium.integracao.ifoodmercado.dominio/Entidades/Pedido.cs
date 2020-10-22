using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class Pedido: Entidade
    {
        public Int64? IDEMPRESA { get; private set; }
        public virtual EmpresaMysql Empresa { get; private set; }
        public Int64? IDFUNC { get; private set; }
        public virtual Funcionario Funcionario { get; private set; }
        public Int64? IDCLIENTE { get; private set; }
        public virtual Cliente Cliente { get; private set; }
        public Int64? IDENDERECO { get; private set; }
        public virtual Endereco Endereco { get; private set; }
        public Int64? IDCAIXA { get; private set; }
        public virtual Caixa Caixa { get; private set; }
        public Int64? IDPDV { get; private set; }
        public virtual PontoVenda PontoVenda { get; private set; }
        public string CDPEDIDO { get; private set; }
        public DateTime? DTPEDIDO { get; private set; }
        public int? STPEDIDO { get; private set; }
        public double? VLPEDIDO { get; private set; }
        public double? VLACRES { get; private set; }
        public double? VLDESC { get; private set; }
        public double? VLOUTROS { get; private set; }
        public double? VLTOTAL { get; private set; }
        public string DSOBS { get; private set; }

        public virtual IReadOnlyCollection<PedidoItem> PedidoItem { get { return _pedidoItem.ToList(); } }
        private IList<PedidoItem> _pedidoItem { get; set; }
        public virtual IReadOnlyCollection<PedidoPagamento> PedidoPagamento { get { return _pedidoPagamento.ToList(); } }
        private IList<PedidoPagamento> _pedidoPagamento { get; set; }
        public virtual IReadOnlyCollection<PedidoVenda> Pedidovenda { get { return _pedidovenda.ToList(); } }
        private IList<PedidoVenda> _pedidovenda { get; set; }
        private Pedido()
        {
            _pedidoItem = new List<PedidoItem>();
            _pedidoPagamento = new List<PedidoPagamento>();
            _pedidovenda = new List<PedidoVenda>();
        }
    }
}
