using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class EstoqueProduto: Entidade
    {
        public virtual Produto Produto { get; private set; }
        public Int64? IDPRODUTO { get; private set; }
        public virtual Estoque Estoque { get; private set; }
        public Int64? IDESTOQUE { get; private set; }
        public double? NUQTD { get; private set; }

        private EstoqueProduto()
        {

        }
    }
}
