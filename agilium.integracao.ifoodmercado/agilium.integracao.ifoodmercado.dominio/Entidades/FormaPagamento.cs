using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class FormaPagamento: Entidade
    {
        public Int64? IDEMPRESA { get; private set; }
        public virtual EmpresaMysql Empresa { get; private set; }
        public string DSFORMAPAG { get; private set; }
        public int? STFORMAPAG { get; private set; }

        public virtual IReadOnlyCollection<PedidoPagamento> PedidoPagamento { get { return _pedidoPagamento.ToList(); } }
        private IList<PedidoPagamento> _pedidoPagamento { get; set; }
        private FormaPagamento()
        {
            _pedidoPagamento = new List<PedidoPagamento>();
        }
    }
}
