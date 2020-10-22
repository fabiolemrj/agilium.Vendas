using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class MotivoDevolucao: Entidade
    {
        public Int64? IDEMPRESA { get; private set; }
        public virtual EmpresaMysql Empresa { get; private set; }
        public string DSMOTDEV { get; private set; }
        public int? STMOTDEV { get; private set; }
        public virtual IReadOnlyCollection<Devolucao> Devolucao { get { return _devolucao.ToList(); } }
        private IList<Devolucao> _devolucao { get; set; }
        private MotivoDevolucao()
        {
            _devolucao = new List<Devolucao>();
        }
    }
}
