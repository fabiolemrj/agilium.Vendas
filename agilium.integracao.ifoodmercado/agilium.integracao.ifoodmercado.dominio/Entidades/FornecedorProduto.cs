using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class FornecedorProduto: Entidade
    {
        public Int64 IDFORN { get; private set; }
        public virtual Fornecedor Fornecedor { get; private set; }
        public Int64 IDPRODUTO { get; private set; }
        public virtual Produto Produto { get; private set; }
        private FornecedorProduto()
        {

        }

    }
}
