using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class VendaTemporaria: Entidade
    {
        public Int64? IDCAIXA { get; private set; }
        public virtual Caixa Caixa { get; private set; }
        public Int64? IDCLIENTE { get; private set; }
        public virtual Cliente Cliente { get; private set; }
        public int? SQVENDA { get; private set; }
        public DateTime? DTHRVENDA { get; private set; }
        public string NUCPFCNPJ { get; private set; }
        public double? VLVENDA { get; private set; }
        public double? VLDESC { get; private set; }
        public double? VLTOTAL { get; private set; }
        public double? VLACRES { get; private set; }
        public int? STVENDA { get; private set; }
        public string DSINFCOMPL { get; private set; }
        public double? VLTOTIBPTFED { get; private set; }
        public double? VLTOTIBPTEST { get; private set; }
        public double? VLTOTIBPTMUN { get; private set; }
        public double? VLTOTIBPTIMP { get; private set; }
        public int? NUNF { get; private set; }
        public string DSSERIE { get; private set; }
        public int? TPDOC { get; private set; }
        public int? STEMISSAO { get; private set; }
        public string DSCHAVEACESSO { get; private set; }
        public virtual IReadOnlyCollection<VendaTemporariaEspelho> VendaEspelho { get { return _vendaEspelho.ToList(); } }
        private IList<VendaTemporariaEspelho> _vendaEspelho { get; set; }
        public virtual IReadOnlyCollection<VendaTemporariaItem> VendaItem { get { return _vendaItem.ToList(); } }
        private IList<VendaTemporariaItem> _vendaItem { get; set; }
        public virtual IReadOnlyCollection<VendaTemporariaMoeda> VendaMoeda { get { return _vendaMoeda.ToList(); } }
        private IList<VendaTemporariaMoeda> _vendaMoeda { get; set; }
        private VendaTemporaria()
        {
            _vendaEspelho = new List<VendaTemporariaEspelho>();
            _vendaItem = new List<VendaTemporariaItem>();
            _vendaMoeda = new List<VendaTemporariaMoeda>();
        }
    }
}
