using agilium.integracao.ifoodmercado.dominio.Entidades;
using agilium.integracao.ifoodmercado.dominio.Interfaces.Repositorios;
using agilium.integracao.ifoodmercado.infra.Context;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace agilium.integracao.ifoodmercado.infra.Repositorios
{
    public class PedidoPagamentoRepositorio: EFRepositorio<PedidoPagamento>, IPedidoFormaPagamentoRepositorio
    {
        public PedidoPagamentoRepositorio(dbContextAgilium context) : base(context)
        {

        }
      
    }
}
