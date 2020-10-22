using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class Vale: Entidade
    {
        public Int64? IDEMPRESA { get; private set; }
        public virtual EmpresaMysql Empresa { get; private set; }
        public Int64? IDCLIENTE { get; private set; }
        public virtual Cliente Cliente { get; private set; }
        public string CDVALE { get; private set; }
        public DateTime? DTHRVALE { get; private set; }
        public int? TPVALE { get; private set; }
        public int? STVALE { get; private set; }
        public double? VLVALE { get; private set; }
        public string CDBARRA { get; private set; }
        public virtual IReadOnlyCollection<Devolucao> Devolucao { get { return _devolucao.ToList(); } }
        private IList<Devolucao> _devolucao { get; set; }
        private Vale()
        {
            _devolucao = new List<Devolucao>();
        }
    }
}
