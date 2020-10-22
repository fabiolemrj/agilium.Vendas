using agilium.integracao.ifoodmercado.dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class PontoVenda: Entidade
    {
        public Int64 IDEMPRESA { get; private set; }
        public virtual EmpresaMysql Empresa { get; private set; }
        public string CDPDV { get; private set; }
        public string DSPDV { get; private set; }
        public string NMMAQUINA { get; private set; }
        public string DSCAMINHO_CERT { get; private set; }
        public string DSSENHA_CERT { get; private set; }
        public Int64? IDESTOQUE { get; private set; }
        public virtual Estoque Estoque { get; private set; }

        public virtual IReadOnlyCollection<Caixa> Caixas { get { return _caixas.ToList(); } }
        private IList<Caixa> _caixas { get; set; }
        public virtual IReadOnlyCollection<Pedido> Pedidos { get { return _pedidos.ToList(); } }
        private IList<Pedido> _pedidos { get; set; }
        private PontoVenda()
        {
            _caixas = new List<Caixa>();
            _pedidos = new List<Pedido>();
        }
    }
}
