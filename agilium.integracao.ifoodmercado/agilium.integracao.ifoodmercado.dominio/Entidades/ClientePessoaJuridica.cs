using agilium.integracao.ifoodmercado.dominio.ObjetosValor;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class ClientePessoaJuridica: Entidade
    {
        public virtual Cliente Cliente { get; private set; }
        public string NMRZSOCIAL { get; private set; }
        public CnpjVO Cnpj { get; private set; }
        public string DSINSCREST { get; private set; }
        private ClientePessoaJuridica()
        {

        }
    }
}
