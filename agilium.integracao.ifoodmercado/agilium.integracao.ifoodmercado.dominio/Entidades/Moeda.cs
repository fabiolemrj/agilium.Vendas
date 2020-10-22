using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class Moeda: Entidade
    {
        public Int64? IDEMPRESA { get; private set; }
        public virtual EmpresaMysql Empresa { get; private set; }
        public string CDMOEDA { get; private set; }
        public string DSMOEDA { get; private set; }
        public int? STMOEDA { get; private set; }
        public int? TPDOCFISCAL { get; private set; }
        public int? TPMOEDA { get; private set; }
        public double? PCTAXA { get; private set; }
        public int? STTROCO { get; private set; }
        public string COR_BOTAO { get; private set; }
        public string COR_FONTE { get; private set; }
        public string TECLA_ATALHO { get; private set; }
        public virtual IReadOnlyCollection<CaixaMoeda> CaixaMoedas { get { return _caixaMoedas.ToList(); } }
        private IList<CaixaMoeda> _caixaMoedas { get; set; }
        public virtual IReadOnlyCollection<VendaMoeda> VendaMoedas { get { return _vendaMoedas.ToList(); } }
        private IList<VendaMoeda> _vendaMoedas { get; set; }
        public virtual IReadOnlyCollection<VendaTemporariaMoeda> VendaTemporariaMoedas { get { return _vendaTemporariaMoedas.ToList(); } }
        private IList<VendaTemporariaMoeda> _vendaTemporariaMoedas { get; set; }
        public virtual IReadOnlyCollection<PedidoPagamento> PedidoPagamento { get { return _pedidoPagamento.ToList(); } }
        private IList<PedidoPagamento> _pedidoPagamento { get; set; }
        private Moeda()
        {
            _caixaMoedas = new List<CaixaMoeda>();
            _vendaMoedas = new List<VendaMoeda>();
            _vendaTemporariaMoedas = new List<VendaTemporariaMoeda>();
            _pedidoPagamento = new List<PedidoPagamento>();
        }
    }
}
