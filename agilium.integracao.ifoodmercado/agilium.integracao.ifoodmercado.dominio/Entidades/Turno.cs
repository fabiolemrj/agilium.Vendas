using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class Turno: Entidade
    {
        public Int64? IDEMPRESA { get; private set; }
        public virtual EmpresaMysql Empresa { get; private set; }
        public Int64? IDUSUARIOINI { get; private set; }
        public virtual Usuario UsuarioInicial { get; private set; }
        public Int64? IDUSUARIOFIM { get; private set; }
        public virtual Usuario UsuarioFinal { get; private set; }
        public DateTime? DTTURNO { get; private set; }
        public int? NUTURNO { get; private set; }
        public DateTime? DTHRINI { get; private set; }
        public DateTime? DTHRFIM { get; private set; }
        public string DSOBS { get; private set; }

        public virtual IReadOnlyCollection<Compra> Compra { get { return _compra.ToList(); } }
        private IList<Compra> _compra { get; set; }
        private Turno()
        {
            _compra = new List<Compra>();
        }
    }
}
