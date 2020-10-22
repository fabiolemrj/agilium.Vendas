using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class Cep: Entidade
    {
        public int id_logradouro { get; private set; }
        public int id_cidade { get; private set; }
        public string cep { get; private set; }
        public string uf { get; private set; }
        public string ender { get; private set; }
        public string cidade { get; private set; }
        public string bairro { get; private set; }
        public int? ibge { get; private set; }
        public string tipo { get; private set; }
        private Cep()
        {

        }
    }
}
