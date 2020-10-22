using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class CategFinanc: Entidade
    {
        public string NMCATEG { get; private set; }
        public int STCATEG { get; private set; }
        public virtual IReadOnlyCollection<ContaReceber> ContaReceber { get { return _contaReceber.ToList(); } }
        private IList<ContaReceber> _contaReceber { get; set; }
        public virtual IReadOnlyCollection<ContaPagar> ContaPagar { get { return _contaPagar.ToList(); } }
        private IList<ContaPagar> _contaPagar { get; set; }
        public CategFinanc()
        {
            _contaPagar = new List<ContaPagar>();
        }
    }
}
