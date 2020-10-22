using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class NotaFiscalInutil: Entidade
    {
        public Int64? IDEMPRESA { get; private set; }
        public virtual EmpresaMysql Empresa { get; private set; }
        public string CDNFINUTIL { get; private set; }
        public string DSMOTIVO { get; private set; }
        public int? NUANO { get; private set; }
        public string DSMODELO { get; private set; }
        public string DSSERIE { get; private set; }
        public int? NUNFINI { get; private set; }
        public int? NUNFFIM { get; private set; }
        public DateTime? DTHRINUTIL { get; private set; }
        public int? STINUTIL { get; private set; }
        public string DSPROTOCOLO { get; private set; }
        public string DSXML { get; private set; }
        private NotaFiscalInutil()
        {

        }
    }
}
