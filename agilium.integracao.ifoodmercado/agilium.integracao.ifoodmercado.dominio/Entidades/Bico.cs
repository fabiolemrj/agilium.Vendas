using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class Bico: Entidade
    {
        public Int64? IDBOMBA { get; private set; }
        public virtual Bomba Bomba { get; private set; }
        public string CDBICO { get; private set; }
        public Int64? IDESTOQUE { get; private set; }
        public virtual Estoque Estoque { get; private set; }
        public int? STBICO { get; private set; }
        private Bico()
        {

        }
    }
}
