using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class EstoqueHistorico: Entidade
    {
        public virtual Estoque Estoque { get; private set; }
        public Int64? IDESTOQUE { get; private set; }
        public virtual Produto Produto { get; private set; }
        public Int64? IDPRODUTO { get; private set; }
        public Int64? IDITEM { get; private set; }
        public Int64? IDLANC { get; private set; }
        public DateTime? DTHRHST { get; private set; }
        public string NMUSUARIO { get; private set; }
        public int? TPHST { get; private set; }
        public string DSHST { get; private set; }
        public double? QTDHST { get; private set; }

        public virtual IReadOnlyCollection<Perda> Perdas { get { return _perda.ToList(); } }
        private IList<Perda> _perda { get; set; }

        private EstoqueHistorico()
        {
            _perda = new List<Perda>();
        }
    }
}
