﻿using agilium.integracao.ifoodmercado.dominio.Entidades;
using agilium.integracao.ifoodmercado.dominio.Interfaces.Repositorios;
using agilium.integracao.ifoodmercado.infra.Context;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.Repositorios
{
    public class BombaRepositorio: EFRepositorio<Bomba>, IBombaRepositorio
    {
        public BombaRepositorio(dbContextAgilium context) : base(context)
        {

        }
    }
}
