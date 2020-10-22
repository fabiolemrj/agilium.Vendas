using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class Compra: Entidade
    {
        public Int64? IDEMPRESA { get; private set; }
        public virtual EmpresaMysql Empresa { get; private set; }
        public Int64? IDFORN { get; private set; }
        public virtual Fornecedor Fornecedor { get; private set; }
        public Int64? IDTURNO { get; private set; }
        public virtual Turno Turno { get; private set; }
        public DateTime? DTCOMPRA { get; private set; }
        public DateTime? DTCAD { get; private set; }
        public string CDCOMPRA { get; private set; }
        public int? STCOMPRA { get; private set; }
        public DateTime? DTNF { get; private set; }
        public string NUNF { get; private set; }
        public string DSSERIENF { get; private set; }
        public string DSCHAVENFE { get; private set; }
        public int? TPCOMPROVANTE { get; private set; }
        public int? NUCFOP { get; private set; }
        public double? VLICMSRETIDO { get; private set; }
        public double? VLBSCALCICMS { get; private set; }
        public double? VLICMS { get; private set; }
        public double? VLBSCALCSUB { get; private set; }
        public double? VLICMSSUB { get; private set; }
        public double? VLISENCAO { get; private set; }
        public double? VLTOTPROD { get; private set; }
        public double? VLFRETE { get; private set; }
        public double? VLSEGURO { get; private set; }
        public double? VLDESCONTO { get; private set; }
        public double? VLOUTROS { get; private set; }
        public double? VLIPI { get; private set; }
        public double? VLTOTAL { get; private set; }
        public string DSOBS { get; private set; }
        public int? STIMPORTADA { get; private set; }
        public virtual IReadOnlyCollection<CompraItem> CompraItem { get { return _compraItem.ToList(); } }
        private IList<CompraItem> _compraItem { get; set; }
        public virtual IReadOnlyCollection<CompraFiscal> CompraFiscal { get { return _compraFiscal.ToList(); } }
        private IList<CompraFiscal> _compraFiscal { get; set; }
        private Compra()
        {
            _compraItem = new List<CompraItem>();
            _compraFiscal = new List<CompraFiscal>();
        }
    }
}
