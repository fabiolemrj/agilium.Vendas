using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class Bomba: Entidade
    {
        public Int64? IDEMPRESA { get; private set; }
        public virtual EmpresaMysql Empresa { get; private set; }
        public string CDBOMBA { get; private set; }
        public string NUCNPJFABR { get; private set; }
        public string NMFABR { get; private set; }
        public string DSMODELO { get; private set; }
        public string DSSERIE { get; private set; }
        public int? STBOMBA { get; private set; }

        public virtual IReadOnlyCollection<Bico> Bicos { get { return _bico.ToList(); } }
        private IList<Bico> _bico { get; set; }
        private Bomba()
        {
            _bico = new List<Bico>();
        }

        public Bomba(long? iDEMPRESA, string cDBOMBA, string nUCNPJFABR, string nMFABR, string dSMODELO, string dSSERIE, int? sTBOMBA)
        {
            _bico = new List<Bico>();

            IDEMPRESA = iDEMPRESA;
            CDBOMBA = cDBOMBA;
            NUCNPJFABR = nUCNPJFABR;
            NMFABR = nMFABR;
            DSMODELO = dSMODELO;
            DSSERIE = dSSERIE;
            STBOMBA = sTBOMBA;
        }
    }
}
