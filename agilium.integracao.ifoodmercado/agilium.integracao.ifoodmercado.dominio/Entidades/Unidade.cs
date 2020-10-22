using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class Unidade: Entidade
    {
        public string NMSIGLA { get; private set; }
        public string DSSIGLA { get; private set; }
        public int? STATIVO { get; private set; }
        private Unidade()
        {

        }
         
    }
}
