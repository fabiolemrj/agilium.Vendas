using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class ConfiguracaoCertificado: Entidade
    {
        public Int64? IDEMPRESA { get; private set; }
        public virtual EmpresaMysql Empresa { get; private set; }
        public string NMMAQUINA { get; private set; }
        public string DSCAMINHO { get; private set; }
        public string DSSENHA { get; private set; }
        public ConfiguracaoCertificado()
        {

        }
    }
}
