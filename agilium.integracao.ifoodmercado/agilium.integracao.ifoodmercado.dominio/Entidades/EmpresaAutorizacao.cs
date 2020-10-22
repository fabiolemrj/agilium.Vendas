using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class EmpresaAutorizacao: Entidade
    {
        public Int64 IDEMPRESA { get; private set; }
        public virtual EmpresaMysql Empresa { get; private set; }
        public Int64 IDUSUARIO { get; private set; }
        public virtual Usuario Usuario { get; private set; }
        private EmpresaAutorizacao()
        {

        }
    }
}
