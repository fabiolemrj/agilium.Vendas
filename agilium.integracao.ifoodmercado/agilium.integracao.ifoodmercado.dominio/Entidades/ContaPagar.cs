﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class ContaPagar: Entidade
    {
        public Int64? IDCONTAPAI { get; private set; }
        public virtual ContaPagar ContaPagaPai { get; private set; }
        public Int64? IDCATEG_FINANC { get; private set; }
        public virtual CategFinanc CategFinanc { get; private set; }
        public Int64? IDUSUARIO { get; private set; }
        public virtual Usuario Usuario { get; private set; }
        public Int64? IDFORNEC { get; private set; }
        public virtual Fornecedor Fornecedor { get; private set; }
        public Int64? IDCONTA { get; private set; }
        public virtual PlanoConta PlanoConta { get; private set; }
        public Int64? IDEMPRESA { get; private set; }
        public virtual EmpresaMysql Empresa { get; private set; }
        public Int64? IDLANC { get; private set; }
        public virtual PlanoContaLancamento PlanoContaLancamento { get; private set; }
        public string DESCR { get; private set; }
        public DateTime? DTVENC { get; private set; }
        public DateTime? DTPAG { get; private set; }
        public double? VLCONTA { get; private set; }
        public double? VLDESC { get; private set; }
        public double? VLACRESC { get; private set; }
        public int? PARCINI { get; private set; }
        public int? TPCONTA { get; private set; }
        public int? STCONTA { get; private set; }
        public string OBS { get; private set; }
        public string NUMNF { get; private set; }
        public DateTime? DTNF { get; private set; }
        public DateTime? DTCAD { get; private set; }

        public virtual IReadOnlyCollection<ContaPagar> ContaPagarPai { get { return _contaPagarPai.ToList(); } }
        private IList<ContaPagar> _contaPagarPai { get; set; }
        private ContaPagar()
        {
            _contaPagarPai = new List<ContaPagar>();
        }
    }
}
