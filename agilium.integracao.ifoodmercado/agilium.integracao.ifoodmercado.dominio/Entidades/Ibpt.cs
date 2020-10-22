using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class Ibpt: Entidade
    {
        public string NCM { get; private set; }
        public int? EX { get; private set; }
        public int? TIPO { get; private set; }
        public string DESCRICAO { get; private set; }
        public double? NACIONALFEDERAL { get; private set; }
        public double? IMPORTADOSFEDERAL { get; private set; }
        public double? ESTADUAL { get; private set; }
        public double? MUNICIPAL { get; private set; }
        public DateTime? INICIOVIG { get; private set; }
        public DateTime? FIMVIG { get; private set; }
        public string VERSAO { get; private set; }
        private Ibpt()
        {

        }

    }
}
