using agilium.integracao.ifoodmercado.dominio.Entidades;
using agilium.integracao.ifoodmercado.dominio.Interfaces.Repositorios;
using agilium.integracao.ifoodmercado.infra.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agilium.integracao.ifoodmercado.infra.Repositorios
{
    public class BombaRepositorio: EFRepositorio<Bomba>, IBombaRepositorio
    {
        public BombaRepositorio(dbContextAgilium context) : base(context)
        {

        }

        public override async Task<string> GerarCodigo()
        {
            
            var teste = _context.ValorCodigo.FromSqlRaw("call countCodigoGenerico(3);").ToList().FirstOrDefault(); //_context.GeraCodigoBico();

            return await Task<int>.Run(() => teste.Codigo.ToString());
        }
    }
}
