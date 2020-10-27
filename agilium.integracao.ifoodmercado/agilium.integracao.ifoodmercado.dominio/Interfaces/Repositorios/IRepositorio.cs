using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace agilium.integracao.ifoodmercado.dominio.Interfaces.Repositorios
{
    public interface IRepositorio<TEntidade> where TEntidade : class
    {
        Task<TEntidade> Adicionar(TEntidade obj);
        Task Atualizar(TEntidade obj);
        Task Remover(TEntidade obj);
        Task<TEntidade> ObterPorId(Int64 id);
        Task<TEntidade> ObterPorId(Guid id);
        Task<IEnumerable<TEntidade>> ObterTodos();
        Task<IEnumerable<TEntidade>> ObterLista(Expression<Func<TEntidade, bool>> predicated);
        Task<IEnumerable<TEntidade>> ObterLista(Expression<Func<TEntidade, bool>> predicated, params string[] includes);
        Task<TEntidade> Obter(Expression<Func<TEntidade, bool>> predicated);
        Task<TEntidade> Obter(Expression<Func<TEntidade, bool>> predicated, params string[] includes);
        Task<string> GerarCodigo();
    }
}
