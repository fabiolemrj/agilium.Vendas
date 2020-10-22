using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class LogSistema: Entidade
    {
        public string usuario { get; private set; }
        public string descr { get; private set; }
        public string tela { get; private set; }
        public string controle { get; private set; }
        public string maquina { get; private set; }
        public DateTime? data_log { get; private set; }
        public string hora_log { get; private set; }
        public string SQL_log { get; private set; }
        public string so { get; private set; }
        private LogSistema()
        {

        }
    }
}
