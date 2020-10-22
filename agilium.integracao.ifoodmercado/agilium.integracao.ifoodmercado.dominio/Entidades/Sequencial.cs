using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class Sequencial: Entidade
    {
        public string CHAVE { get; private set; }
        public Int64? IDEMPRESA { get; private set; }
        public virtual EmpresaMysql Empresa { get; private set; }
        public int? SEQUENCIAL { get; private set; }
        private Sequencial()
        {

        }
    }
}
