using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class ProdutoComposicao: Entidade
    {
        public Int64 idProduto { get; private set; }
        public virtual Produto Produto { get; private set; }
        public Int64? idProdutoComposicao { get; private set; }
        public Int64? idEstoque { get; private set; }
        public decimal? Quantidade { get; private set; }
        public decimal? Preco { get; private set; }

        public ProdutoComposicao(Produto produto, long idProdutoComposicao, long idEstoque, decimal quantidade, decimal preco)
        {
            Produto = produto;
            this.idProdutoComposicao = idProdutoComposicao;
            this.idEstoque = idEstoque;
            Quantidade = quantidade;
            Preco = preco;

            AddNotifications(produto);

            AddNotifications(new Flunt.Validations.Contract()
              .Requires()
              .IsGreaterOrEqualsThan(quantidade,0, "quantidade", "O campo quantidade deve ser igual ou maior a zero")
              .IsGreaterOrEqualsThan(preco, 0, "preco", "O campo Preco deve ser igual ou maior a zero")
              );
        }

        private ProdutoComposicao()
        {

        }



        //        IDCOMPOSICAO bigint PK
        //IDPRODUTO bigint
        //IDPRODUTO_COMP bigint
        //IDESTOQUE bigint
        //NUQTD double
        //NUPRECO doubl
    }
}
