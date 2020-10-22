using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class ProdutoPreco: Entidade
    {
        public Int64? idProduto { get; private set; }
        public virtual Produto Produto { get; private set; }
        public string Usuario { get; private set; }
        public decimal? Preco { get; private set; }
        public decimal? PrecoAnterior { get; private set; }
        public DateTime? DataPreco { get; private set; }

        private ProdutoPreco()
        {

        }

    }
}
