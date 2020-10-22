using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class Cfop: Entidade
    {
        public int CDCFOP { get; private set; }
        public string DSCFOP { get; private set; }
        public string TPCFOP { get; private set; }
        private Cfop()
        {

        }
    }
}
