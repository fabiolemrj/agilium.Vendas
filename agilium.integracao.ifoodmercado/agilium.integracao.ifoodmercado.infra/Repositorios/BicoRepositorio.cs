using agilium.integracao.ifoodmercado.dominio.Entidades;
using agilium.integracao.ifoodmercado.dominio.Interfaces.Repositorios;
using agilium.integracao.ifoodmercado.infra.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agilium.integracao.ifoodmercado.infra.Repositorios
{
    public class BicoRepositorio: EFRepositorio<Bico>, IBicoRepositorio
    {
        public BicoRepositorio(dbContextAgilium context) : base(context)
        {

        }
        public override  Task<string> GerarCodigo()
        {

            var codigo = _context.Bico.Max(x=>x.CDBICO);
            int intCod = 0;
            int.TryParse(codigo, out intCod);

            intCod++;
            
            return Task<int>.Run(() =>  intCod.ToString()) ;
        }
    }
}
