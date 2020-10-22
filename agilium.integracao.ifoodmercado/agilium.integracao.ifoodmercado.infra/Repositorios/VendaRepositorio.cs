using agilium.integracao.ifoodmercado.dominio.Entidades;
using agilium.integracao.ifoodmercado.dominio.Interfaces.Repositorios;
using agilium.integracao.ifoodmercado.infra.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace agilium.integracao.ifoodmercado.infra.Repositorios
{
    public class VendaRepositorio: EFRepositorio<Venda>, IVendaRepositorio
    {
        public VendaRepositorio(dbContextAgilium context) : base(context)
        {
            
        }
        public async Task<VendaItem> AdicionarItem(VendaItem obj)
        {
            await _context.Set<VendaItem>().AddAsync(obj);
            return obj;
        }

        public async Task AdicionarListasItem(IEnumerable<VendaItem> listaobj)
        {
            await _context.Set<VendaItem>().AddRangeAsync(listaobj);            
        }

        public async Task AtualizarItem(VendaItem obj)
        {
            await Task.Run(() => _context.Set<VendaItem>().Update(obj));
        }

        public async Task RemoverItem(VendaItem obj)
        {
            await Task.Run(() => _context.Set<VendaItem>().Remove(obj));
        }

    }
}
