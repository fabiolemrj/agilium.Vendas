using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class Licenca: Entidade
    {
        public Int64? IDEMPRESA { get; private set; }
        public virtual  EmpresaMysql Empresa { get; private set; }
        public string K1 { get; private set; }
        public string K2 { get; private set; }
        public string K3 { get; private set; }
        public string K4 { get; private set; }
        public string K5 { get; private set; }
        public string K6 { get; private set; }
        public string K7 { get; private set; }
        private Licenca()
        {

        }
    }
}
