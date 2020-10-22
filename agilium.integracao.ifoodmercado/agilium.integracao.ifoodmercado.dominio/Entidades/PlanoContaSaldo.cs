using System;
using System.Collections.Generic;
using System.Net.Cache;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class PlanoContaSaldo: Entidade
    {
        public Int64? IDCONTA { get; private set; }
        public virtual PlanoConta PlanoConta { get; private set; }
        public DateTime? DTHRATU { get; private set; }
        public int? NUANOMESREF { get; private set; }
        public double? VLSALDO { get; private set; }
        private PlanoContaSaldo()
        {

        }
    }
}
