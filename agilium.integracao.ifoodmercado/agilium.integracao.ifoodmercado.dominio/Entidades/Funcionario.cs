using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class Funcionario: Entidade
    {
        public Int64? IDUSUARIO { get; private set; }
        public virtual Usuario Usuario { get; private set; }
        public Int64? IDENDERECO { get; private set; }
        public virtual Endereco Endereco { get; private set; }
        public Int64? IDEMPRESA { get; private set; }
        public virtual EmpresaMysql Empresa { get; private set; }
        public string CDFUNC { get; private set; }
        public string NMFUNC { get; private set; }
        public int? NUTURNO { get; private set; }
        public int? STFUNC { get; private set; }
        public string NUCPF { get; private set; }
        public string NURG { get; private set; }
        public DateTime? DTADM { get; private set; }
        public DateTime? DTDEM { get; private set; }
        public string DSRFID { get; private set; }
        public int? STNOTURNO { get; private set; }
        public virtual IReadOnlyCollection<Pedido> Pedidos { get { return _pedidos.ToList(); } }
        private IList<Pedido> _pedidos { get; set; }
        private Funcionario()
        {
            _pedidos = new List<Pedido>();
        }
         
    }
}
