using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class ContatoEmpresa: Entidade
    {
        public virtual Contato Contato { get; private set; }
        public Int64 IDCONTATO { get; private set; }
        public virtual EmpresaMysql Empresa { get; private set; }
        public Int64 IDEMPRESA { get; private set; }

        private ContatoEmpresa()
        {

        }
         
    }
}
