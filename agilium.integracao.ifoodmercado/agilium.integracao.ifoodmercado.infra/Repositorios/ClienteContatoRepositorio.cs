using agilium.integracao.ifoodmercado.dominio.Entidades;
using agilium.integracao.ifoodmercado.dominio.Interfaces.Repositorios;
using agilium.integracao.ifoodmercado.infra.Context;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.Repositorios
{
    public class ClienteContatoRepositorio: EFRepositorio<ClienteContato>, IClienteContatoRepositorio
    {
        public ClienteContatoRepositorio(dbContextAgilium context) : base(context)
        {

        }
    }
}
