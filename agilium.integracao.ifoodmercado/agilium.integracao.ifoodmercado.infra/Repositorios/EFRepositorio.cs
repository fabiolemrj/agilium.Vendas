using agilium.integracao.ifoodmercado.dominio.Interfaces.Repositorios;
using agilium.integracao.ifoodmercado.infra.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace agilium.integracao.ifoodmercado.infra.Repositorios
{
 
    public class EFRepositorio<TEntidade> : IDisposable, IRepositorio<TEntidade> where TEntidade : class
    {
        protected readonly dbContextAgilium _context;

        public EFRepositorio(dbContextAgilium context)
        {
            _context = context;
        }

        public async Task<TEntidade> Adicionar(TEntidade obj)
        {         
            await _context.Set<TEntidade>().AddAsync(obj);
            return obj;         
        }

        public async Task Atualizar(TEntidade obj)
        {
            await Task.Run(() => _context.Set<TEntidade>().Update(obj));
     
        }

        public void Dispose()
        {
            _context.DisposeAsync();
        }

        public async Task<TEntidade> Obter(Expression<Func<TEntidade, bool>> predicated)
        {
            return await _context.Set<TEntidade>().Where(predicated).AsNoTracking().FirstOrDefaultAsync();
        }

        public async Task<TEntidade> Obter(Expression<Func<TEntidade, bool>> predicated, params string[] includes)
        {
            var result = _context.Set<TEntidade>().Where(predicated).AsNoTracking();
            foreach (var item in includes)
            {
                result = result.Include(item);
            }

            return await result.FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<TEntidade>> ObterLista(Expression<Func<TEntidade, bool>> predicated)
        {
            return await _context.Set<TEntidade>().Where(predicated).AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<TEntidade>> ObterLista(Expression<Func<TEntidade, bool>> predicated, params string[] includes)
        {
            var result = _context.Set<TEntidade>().Where(predicated).AsNoTracking();

            foreach (var item in includes)
            {
                result = result.Include(item);
            }

            return await result.ToListAsync();
        }

        public async Task<TEntidade> ObterPorId(long id)
        {
            return await _context.Set<TEntidade>().FindAsync(id);
        }

        public async Task<TEntidade> ObterPorId(Guid id)
        {
            return await _context.Set<TEntidade>().FindAsync(id);
        }

        public async Task<IEnumerable<TEntidade>> ObterTodos()
        {
            return await _context.Set<TEntidade>().ToListAsync();
        }

        public async Task Remover(TEntidade obj)
        {
            await Task.Run(() => _context.Set<TEntidade>().Remove(obj));
        }
    }
}
