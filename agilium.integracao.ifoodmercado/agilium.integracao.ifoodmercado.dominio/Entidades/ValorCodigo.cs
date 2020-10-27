using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class ValorCodigo
    {
        public Int64 Codigo { get; private set; }
        public string Tabela { get; private set; }
        private ValorCodigo()
        {

        }
    }
}
