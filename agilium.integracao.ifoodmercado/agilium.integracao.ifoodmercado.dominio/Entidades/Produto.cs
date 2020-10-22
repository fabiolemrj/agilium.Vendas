using agilium.integracao.ifoodmercado.dominio.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class Produto: Entidade
    {
        public Int64 idEmpresa { get; private set; }
        public virtual EmpresaMysql Empresa { get; private set; }
        public Int64? IDGRUPO { get; private set; }
        public string CDPRODUTO { get; private set; }
        public string NMPRODUTO { get; private set; }
        public string CTPRODUTO { get; private set; }
        public int? TPPRODUTO { get; private set; }
        public string UNCOMPRA { get; private set; }
        public string UNVENDA { get; private set; }
        public int? NURELACAO { get; private set; }
        public double? NUPRECO { get; private set; }
        public double? NUQTDMIN { get; private set; }
        public string CDSEFAZ { get; private set; }
        public string CDANP { get; private set; }
        public string CDNCM { get; private set; }
        public string CDCEST { get; private set; }
        public string CDSERV { get; private set; }
        //public int STPRODUTO { get; private set; }
        public double? VLULTIMACOMPRA { get; private set; }
        public double? VLCUSTOMEDIO { get; private set; }
        public double? PCIBPTFED { get; private set; }
        public double? PCIBPTEST { get; private set; }
        public double? PCIBPTMUN { get; private set; }
        public double? PCIBPTIMP { get; private set; }
        public int? NUCFOP { get; private set; }
        public int? STORIGEMPROD { get; private set; }
        public string DSICMS_CST { get; private set; }
        public double? PCICMS_ALIQ { get; private set; }
        public double? PCICMS_REDUCBC { get; private set; }
        public double? PCICMSST_ALIQ { get; private set; }
        public double? PCICMSST_MVA { get; private set; }
        public double? PCICMSST_REDUCBC { get; private set; }
        public string DSIPI_CST { get; private set; }
        public double? PCIPI_ALIQ { get; private set; }
        public string DSPIS_CST { get; private set; }
        public double? PCPIS_ALIQ { get; private set; }
        public string DSCOFINS_CST { get; private set; }
        public double? PCCOFINS_ALIQ { get; private set; }
        public int? STESTOQUE { get; private set; }
        public int? FLG_IFOOD { get; private set; }
        public virtual IReadOnlyCollection<ProdutoPreco> ProdutoPreco { get { return _produtoPrecos.ToList(); } }
        private IList<ProdutoPreco> _produtoPrecos { get; set; }
        public virtual IReadOnlyCollection<ProdutoFoto> ProdutoFoto { get { return _produtoFoto.ToList(); } }
        private IList<ProdutoFoto> _produtoFoto { get; set; }
        public virtual IReadOnlyCollection<ProdutoComposicao> ProdutoComposicao { get { return _produtoComposicao.ToList(); } }
        private IList<ProdutoComposicao> _produtoComposicao { get; set; }
        public virtual IReadOnlyCollection<EstoqueProduto> EstoqueProdutos { get { return _estoqueProdutos.ToList(); } }
        private IList<EstoqueProduto> _estoqueProdutos { get; set; }
        public virtual IReadOnlyCollection<EstoqueHistorico> EstoqueHistoricos { get { return _estoqueHistoricos.ToList(); } }
        private IList<EstoqueHistorico> _estoqueHistoricos { get; set; }
        public virtual IReadOnlyCollection<ProdutoCodigoBarra> ProdutoCodigoBarras { get { return _produtoCodigoBarra.ToList(); } }
        private IList<ProdutoCodigoBarra> _produtoCodigoBarra { get; set; }
        public virtual IReadOnlyCollection<ClientePreco> ClientePrecos { get { return _clientePreco.ToList(); } }
        private IList<ClientePreco> _clientePreco { get; set; }
        public virtual IReadOnlyCollection<VendaItem> VendaItem { get { return _vendaItem.ToList(); } }
        private IList<VendaItem> _vendaItem { get; set; }
        public virtual IReadOnlyCollection<VendaTemporariaItem> VendaTemporariaItem { get { return _vendaTemporariaItem.ToList(); } }
        private IList<VendaTemporariaItem> _vendaTemporariaItem { get; set; }
        public virtual IReadOnlyCollection<TurnoPreco> TurnoPreco { get { return _turnoPrecos.ToList(); } }
        private IList<TurnoPreco> _turnoPrecos { get; set; }
        public virtual IReadOnlyCollection<FornecedorProduto> ForncedorProduto { get { return _fornecProduto.ToList(); } }
        private IList<FornecedorProduto> _fornecProduto { get; set; }
        public virtual IReadOnlyCollection<PedidoItem> PedidoItem { get { return _pedidoItem.ToList(); } }
        private IList<PedidoItem> _pedidoItem { get; set; }
        public virtual IReadOnlyCollection<Perda> Perdas { get { return _perda.ToList(); } }
        private IList<Perda> _perda { get; set; }
        public virtual IReadOnlyCollection<InventarioItem> Inventario { get { return _inventarioItem.ToList(); } }
        private IList<InventarioItem> _inventarioItem { get; set; }
        public virtual IReadOnlyCollection<CompraItem> CompraItem { get { return _compraItem.ToList(); } }
        private IList<CompraItem> _compraItem { get; set; }

        private Produto()
        {
            _produtoComposicao = new List<ProdutoComposicao>();
            _produtoFoto = new List<ProdutoFoto>();
            _produtoPrecos = new List<ProdutoPreco>();
            _estoqueProdutos = new List<EstoqueProduto>();
            _estoqueHistoricos = new List<EstoqueHistorico>();
            _produtoCodigoBarra = new List<ProdutoCodigoBarra>();
            _clientePreco = new List<ClientePreco>();
            _vendaItem = new List<VendaItem>();
            _vendaTemporariaItem = new List<VendaTemporariaItem>();
            _turnoPrecos = new List<TurnoPreco>();
            _fornecProduto = new List<FornecedorProduto>();
            _pedidoItem = new List<PedidoItem>();
            _perda = new List<Perda>();
            _inventarioItem = new List<InventarioItem>();
            _compraItem = new List<CompraItem>();
        }

       


    }
}
