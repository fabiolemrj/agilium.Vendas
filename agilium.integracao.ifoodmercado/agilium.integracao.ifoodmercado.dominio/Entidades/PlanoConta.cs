using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class PlanoConta: Entidade
    {
        public Int64? IDEMPRESA { get; private set; }
        public virtual EmpresaMysql Empresa { get; private set; }
        public Int64? IDCONTAPAI  { get; private set; }
        public virtual PlanoConta PlanoContaPai { get; private set; }
        public string CDCONTA { get; private set; }
        public string DSCONTA { get; private set; }
        public int? TPCONTA { get; private set; }
        public int? STCONTA { get; private set; }

        public virtual IReadOnlyCollection<PlanoConta> PlanoContasFilho { get { return _planoContasFilho.ToList(); } }
        private IList<PlanoConta> _planoContasFilho { get; set; }
        public virtual IReadOnlyCollection<PlanoContaLancamento> PlanoContaLancamento { get { return _planoContaLancamentos.ToList(); } }
        private IList<PlanoContaLancamento> _planoContaLancamentos { get; set; }
        public virtual IReadOnlyCollection<PlanoContaSaldo> PlanoContaSaldo { get { return _planoContaSaldo.ToList(); } }
        private IList<PlanoContaSaldo> _planoContaSaldo { get; set; }
        public virtual IReadOnlyCollection<ContaReceber> ContaReceber { get { return _contaReceber.ToList(); } }
        private IList<ContaReceber> _contaReceber { get; set; }
        public virtual IReadOnlyCollection<ContaPagar> ContaPagar { get { return _contaPagar.ToList(); } }
        private IList<ContaPagar> _contaPagar { get; set; }
        private PlanoConta()
        {
            _planoContasFilho = new List<PlanoConta>();
            _planoContaLancamentos = new List<PlanoContaLancamento>();
            _planoContaSaldo = new List<PlanoContaSaldo>();
            _contaReceber = new List<ContaReceber>();
            _contaPagar = new List<ContaPagar>();
        }
    }
}
