using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class ConfiguracaoImagem: Entidade
    {
        public string CHAVE { get; private set; }
        public Int64? IDEMPRESA { get; private set; }
        public virtual EmpresaMysql Empresa { get; private set; }
        public byte[] IMG { get; private set; }
        private ConfiguracaoImagem()
        {

        }
    }
}
