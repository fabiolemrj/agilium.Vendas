using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class Ncm: Entidade
    {
        public string CDNCM { get; private set; }
        public string DSDESCR { get; private set; }
        private Ncm()
        {

        }
    }
}
