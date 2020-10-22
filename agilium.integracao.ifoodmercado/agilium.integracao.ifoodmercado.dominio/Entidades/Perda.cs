using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class Perda: Entidade
    {
        public Int64? IDEMPRESA { get; private set; }
        public virtual EmpresaMysql Empresa { get; private set; }
        public Int64? IDESTOQUE { get; private set; }
        public virtual Estoque Estoque { get; private set; }
        public Int64? IDESTOQUEHST { get; private set; }
        public virtual EstoqueHistorico EstoqueHistorico { get; private set; }
        public virtual Produto Produto { get; private set; }
        public Int64? IDPRODUTO { get; private set; }
        public Int64? IDUSUARIO { get; private set; }
        public virtual Usuario Usuario { get; private set; }
        public string CDPERDA { get; private set; }
        public DateTime? DTHRPERDA { get; private set; }
        public int? TPPERDA { get; private set; }
        public int? TPMOV { get; private set; }
        public double? NUQTDPERDA { get; private set; }
        public double? VLCUSTOMEDIO { get; private set; }
        public string DSOBS { get; private set; }
        public virtual IReadOnlyCollection<InventarioItem> InventarioItem { get { return _inventarioItem.ToList(); } }
        private IList<InventarioItem> _inventarioItem { get; set; }
        private Perda()
        {
            _inventarioItem = new List<InventarioItem>();
        }
    }
}
