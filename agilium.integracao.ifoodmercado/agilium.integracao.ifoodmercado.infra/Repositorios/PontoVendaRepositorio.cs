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
    public class PontoVendaRepositorio : EFRepositorio<PontoVenda>, IPontoVendaRepositorio
    {
        public PontoVendaRepositorio(dbContextAgilium context) : base(context)
        {

        }

        public override Task<string> GerarCodigo()
        {
            //var codigo = _context.PontoVenda.Max(x => x.CDPDV);
            //int intCod = 0;
            //int.TryParse(codigo, out intCod);

            //intCod++;
            var teste = _context.ValorCodigo.FromSqlRaw("call countCodigoGenerico(0);").ToList().FirstOrDefault(); //_context.GeraCodigoBico();

            return Task<int>.Run(() => teste.Codigo.ToString());
        }
    }
}
