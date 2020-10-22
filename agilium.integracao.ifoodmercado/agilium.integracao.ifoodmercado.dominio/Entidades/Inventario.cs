using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class Inventario: Entidade
    {
        public Int64? IDEMPRESA { get; private set; }
        public virtual EmpresaMysql Empresa { get; private set; }
        public Int64? IDESTOQUE { get; private set; }
        public virtual Estoque Estoque { get; private set; }
        public string CDINVENT { get; private set; }
        public string DSINVENT { get; private set; }
        public DateTime? DTINVENT { get; private set; }
        public int? STINVENT { get; private set; }
        public string DSOBS { get; private set; }
        public int? TPANALISE { get; private set; }
        public virtual IReadOnlyCollection<InventarioItem> InventarioItem { get { return _inventarioItem.ToList(); } }
        private IList<InventarioItem> _inventarioItem { get; set; }
        private Inventario()
        {
            _inventarioItem = new List<InventarioItem>();
        }
    }
}
