using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class Venda: Entidade
    {
        public Int64? IDCAIXA { get; private set; }
        public virtual Caixa Caixa { get; private set; }
        public Int64? IDCLIENTE { get; private set; }
        public virtual Cliente Cliente { get; private set; }
        public int? SQVENDA { get; private set; }
        public DateTime? DTHRVENDA { get; private set; }
        public string NUCPFCNPJ { get; private set; }
        public double? VLVENDA { get; private set; }
        public double? VLDESC { get; private set; }
        public double? VLTOTAL { get; private set; }
        public double? VLACRES { get; private set; }
        public int? STVENDA { get; private set; }
        public string DSINFCOMPL { get; private set; }
        public double? VLTOTIBPTFED { get; private set; }
        public double? VLTOTIBPTEST { get; private set; }
        public double? VLTOTIBPTMUN { get; private set; }
        public double? VLTOTIBPTIMP { get; private set; }
        public int? NUNF { get; private set; }
        public string DSSERIE { get; private set; }
        public int? TPDOC { get; private set; }
        public int? STEMISSAO { get; private set; }
        public string DSCHAVEACESSO { get; private set; }
        public virtual IReadOnlyCollection<VendaItem> VendaItem { get { return _vendaItem.ToList(); } }
        private IList<VendaItem> _vendaItem { get; set; }
        public virtual IReadOnlyCollection<VendaMoeda> VendaMoeda { get { return _vendaMoeda.ToList(); } }
        private IList<VendaMoeda> _vendaMoeda { get; set; }
        public virtual IReadOnlyCollection<VendaCancelada> VendaCancelada { get { return _vendaCancelada.ToList(); } }
        private IList<VendaCancelada> _vendaCancelada { get; set; }
        public virtual IReadOnlyCollection<VendaEspelho> VendaEspelho { get { return _vendaEspelho.ToList(); } }
        private IList<VendaEspelho> _vendaEspelho { get; set; }
        public virtual IReadOnlyCollection<VendaFiscal> VendaFiscal { get { return _vendaFiscal.ToList(); } }
        private IList<VendaFiscal> _vendaFiscal { get; set; }
        public virtual IReadOnlyCollection<PedidoVenda> Pedidovenda { get { return _pedidovenda.ToList(); } }
        private IList<PedidoVenda> _pedidovenda { get; set; }
        public virtual IReadOnlyCollection<Devolucao> Devolucao { get { return _devolucao.ToList(); } }
        private IList<Devolucao> _devolucao { get; set; }

        private Venda()
        {
            _vendaItem = new List<VendaItem>();
            _vendaMoeda = new List<VendaMoeda>();
            _vendaCancelada = new List<VendaCancelada>();
            _vendaEspelho = new List<VendaEspelho>();
            _vendaFiscal = new List<VendaFiscal>();
            _pedidovenda = new List<PedidoVenda>();
            
        }
    }
}
