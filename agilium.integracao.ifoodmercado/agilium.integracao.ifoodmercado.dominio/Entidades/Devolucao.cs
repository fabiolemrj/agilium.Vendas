using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class Devolucao: Entidade
    {
        public Int64? IDEMPRESA { get; private set; }
        public virtual EmpresaMysql Empresa { get; private set; }
        public Int64? IDVENDA { get; private set; }
        public virtual Venda Venda { get; private set; }
        public Int64? IDCLIENTE { get; private set; }
        public Cliente Cliente { get; private set; }
        public Int64? IDMOTDEV { get; private set; }
        public virtual MotivoDevolucao MotivoDevolucao { get; private set; }
        public Int64? IDVALE { get; private set; }
        public virtual Vale Vale { get; private set; }
        public string CDDEV { get; private set; }
        public DateTime? DTHRDEV { get; private set; }
        public double? VLTOTALDEV { get; private set; }
        public string DSOBSDEV { get; private set; }
        public int? STDEV { get; private set; }
        public virtual IReadOnlyCollection<DevolucaoItem> DevolucaoItem { get { return _devolucaoItem.ToList(); } }
        private IList<DevolucaoItem> _devolucaoItem { get; set; }
        private Devolucao()
        {
            _devolucaoItem = new List<DevolucaoItem>();
        }
    }
}
