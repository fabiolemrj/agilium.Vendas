using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class ProdutoFoto:Entidade
    {
        public Int64? idProduto { get; private set; }
        public virtual Produto Produto { get; private set; }
        public string Descricao { get; private set; }
        public DateTime? Data { get; private set; }
        public byte[] Foto { get; private set; }

        private ProdutoFoto()
        {

        }


    }
}
