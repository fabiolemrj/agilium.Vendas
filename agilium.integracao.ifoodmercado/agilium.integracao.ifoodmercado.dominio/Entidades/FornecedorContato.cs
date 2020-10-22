using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class FornecedorContato: Entidade
    {
        public Int64 IDCONTATO { get; private set; }
        public virtual Contato Contato { get; private set; }
        public Int64 IDFORN { get; private set; }
        public virtual Fornecedor Fornecedor { get; private set; }
        private FornecedorContato()
        {

        }

    }
}
