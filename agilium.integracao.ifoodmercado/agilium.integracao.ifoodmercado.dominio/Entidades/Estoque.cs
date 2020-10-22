using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class Estoque: Entidade
    {
        public Int64 idEmpresa { get; private set; }
        public virtual EmpresaMysql Empresa { get; private set; }
        public string Descricao { get; private set; }
        public int? Tipo { get; private set; }
        public decimal? Capacidade { get; private set; }
        public virtual IReadOnlyCollection<EstoqueProduto> EstoqueProdutos { get { return _estoqueProdutos.ToList(); } }
        private IList<EstoqueProduto> _estoqueProdutos { get; set; }
        public virtual IReadOnlyCollection<EstoqueHistorico> EstoqueHistorico { get { return _estoqueHistorico.ToList(); } }
        private IList<EstoqueHistorico> _estoqueHistorico { get; set; }
        public virtual IReadOnlyCollection<PontoVenda> PontoVenda { get { return _pontoVenda.ToList(); } }
        private IList<PontoVenda> _pontoVenda { get; set; }
        public virtual IReadOnlyCollection<PedidoItem> PedidoItem { get { return _pedidoItem.ToList(); } }
        private IList<PedidoItem> _pedidoItem { get; set; }
        public virtual IReadOnlyCollection<Perda> Perdas { get { return _perda.ToList(); } }
        private IList<Perda> _perda { get; set; }
        public virtual IReadOnlyCollection<Inventario> Inventarios { get { return _inventario.ToList(); } }
        private IList<Inventario> _inventario { get; set; }
        public virtual IReadOnlyCollection<CompraItem> CompraItem { get { return _compraItem.ToList(); } }
        private IList<CompraItem> _compraItem { get; set; }
        private Estoque()
        {
            _estoqueProdutos = new List<EstoqueProduto>();
            _estoqueHistorico = new List<EstoqueHistorico>();
            _pontoVenda = new List<PontoVenda>();
            _pedidoItem = new List<PedidoItem>();
            _perda = new List<Perda>();
            _inventario = new List<Inventario>();
            _compraItem = new List<CompraItem>();
        }


    }
}
