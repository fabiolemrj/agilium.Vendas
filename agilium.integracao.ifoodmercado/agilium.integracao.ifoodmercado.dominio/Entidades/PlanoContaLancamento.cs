using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class PlanoContaLancamento: Entidade
    {

        public Int64? IDCONTA { get; private set; }
        public virtual PlanoConta PlanoConta { get; private set; }
        public DateTime? DTCAD { get; private set; }
        public DateTime? DTREF { get; private set; }
        public int? NUANOMESREF { get; private set; }
        public string DSLANC { get; private set; }
        public double? VLLANC { get; private set; }
        public int? TPLANC { get; private set; }
        public int? STLANC { get; private set; }
        public virtual IReadOnlyCollection<ContaPagar> ContaPagar { get { return _contaPagar.ToList(); } }
        private IList<ContaPagar> _contaPagar { get; set; }

        private PlanoContaLancamento()
        {
            _contaPagar = new List<ContaPagar>();
        }
    }
}
