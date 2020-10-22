using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class Cidade: Entidade
    {
        public int id_cidade { get; private set; }
        public string descricao { get; private set; }
        public string uf { get; private set; }
        public int? codigo_ibge { get; private set; }
        public string ddd { get; private set; }
        private Cidade()
        {

        }
    }
}
