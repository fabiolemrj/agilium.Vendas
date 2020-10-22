using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class Ajuda: Entidade
    {
        public int idajuda { get; private set; }
        public string titulo { get; private set; }
        public string palavras_chave { get; private set; }
        public byte[] conteudo { get; private set; }
        private Ajuda()
        {

        }
    }
}
