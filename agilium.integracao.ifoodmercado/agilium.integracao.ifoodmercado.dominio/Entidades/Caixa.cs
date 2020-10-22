using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class Caixa: Entidade
    {
        public Int64? IDEMPRESA { get; private set; }
        public virtual EmpresaMysql Empresa { get; private set; }
        public Int64? IDTURNO { get; private set; }
        public Int64? IDPDV { get; private set; }
        public virtual PontoVenda PontoVenda { get; private set; }
        public Int64? IDFUNC { get; private set; }
        public int? SQCAIXA { get; private set; }
        public int? STCAIXA { get; private set; }
        public DateTime? DTHRABT { get; private set; }
        public double? VLABT { get; private set; }
        public DateTime? DTHRFECH { get; private set; }
        public double? VLFECH { get; private set; }
        public virtual IReadOnlyCollection<CaixaMoeda> CaixaMoedas { get { return _caixaMoedas.ToList(); } }
        private IList<CaixaMoeda> _caixaMoedas { get; set; }
        public virtual IReadOnlyCollection<CaixaMovimentacao> CaixaMovimentacao { get { return _caixaMovimentacao.ToList(); } }
        private IList<CaixaMovimentacao> _caixaMovimentacao { get; set; }
        public virtual IReadOnlyCollection<Venda> Venda { get { return _venda.ToList(); } }
        private IList<Venda> _venda { get; set; }
        public virtual IReadOnlyCollection<VendaTemporaria> VendaTemporaria { get { return _vendaTemporaria.ToList(); } }
        private IList<VendaTemporaria> _vendaTemporaria { get; set; }
        public virtual IReadOnlyCollection<Pedido> Pedidos { get { return _pedidos.ToList(); } }
        private IList<Pedido> _pedidos { get; set; }
        private Caixa()
        {
            _caixaMoedas = new List<CaixaMoeda>();
            _caixaMovimentacao = new List<CaixaMovimentacao>();
            _venda = new List<Venda>();
            _vendaTemporaria = new List<VendaTemporaria>();
            _pedidos = new List<Pedido>();
        }
    }
}
