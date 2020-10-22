using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class LogErro: Entidade
    {
        public string usuario { get; private set; }
        public string erro { get; private set; }
        public string Tipo { get; private set; }
        public string Tela { get; private set; }
        public string Controle { get; private set; }
        public string Maquina { get; private set; }
        public DateTime? Data_erro { get; private set; }
        public string Hora_erro { get; private set; }
        public string SQL_erro { get; private set; }
        private LogErro()
        {

        }
    }
}
