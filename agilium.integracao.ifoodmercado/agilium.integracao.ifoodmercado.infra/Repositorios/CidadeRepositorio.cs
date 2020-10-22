using agilium.integracao.ifoodmercado.dominio.Entidades;
using agilium.integracao.ifoodmercado.dominio.Interfaces.Repositorios;
using agilium.integracao.ifoodmercado.infra.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.Repositorios
{
    public class CidadeRepositorio: EFRepositorio<Cidade>, ICidadeRepositorio
    {
        public CidadeRepositorio(dbContextAgilium context) : base(context)
        {

        }
    }
}
