using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class Configuracao: Entidade
    {
        public string CHAVE { get; private set; }
        public Int64? IDEMPRESA { get; private set; }
        public virtual EmpresaMysql Empresa { get; private set; }
        public string VALOR { get; private set; }
        private Configuracao()
        {

        }
    }
}
