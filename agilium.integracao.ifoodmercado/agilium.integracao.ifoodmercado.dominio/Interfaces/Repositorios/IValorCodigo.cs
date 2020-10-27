using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace agilium.integracao.ifoodmercado.dominio.Interfaces.Repositorios
{
    public interface IValorCodigo
    {
        Task<int> ObterCodigo();
    }
}
