using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class ProdutoCodigoBarra: Entidade
    {
        public virtual Produto Produto { get; private set; }
        public Int64? IDPRODUTO { get; private set; }
        public string CDBARRA { get; private set; }
        private ProdutoCodigoBarra()
        {

        }
    }
}
