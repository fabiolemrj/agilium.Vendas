using agilium.integracao.ifoodmercado.dominio.Entidades;
using agilium.integracao.ifoodmercado.dominio.Interfaces.Repositorios;
using agilium.integracao.ifoodmercado.infra.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.Repositorios
{
    public class DevolucaoRepositorio: EFRepositorio<Devolucao>, IDevolucaoRepositorio
    {
        public DevolucaoRepositorio(dbContextAgilium context) : base(context)
        {

        }
    }
}
