using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class ClienteContato: Entidade
    {
        public Int64 IDCLIENTE { get; private set; }
        public virtual Cliente Cliente { get; private set; }
        public Int64 IDCONTATO { get; private set; }
        public virtual Contato Contato { get; private set; }
      
        private ClienteContato()
        {

        }

    }
}
