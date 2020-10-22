using agilium.integracao.ifoodmercado.dominio.ObjetosValor;
using System;
using System.Collections.Generic;
using System.Security.Authentication.ExtendedProtection;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class ClientePessoaFisica: Entidade
    {
        public virtual Cliente Cliente { get; private set; }
        public CpfVO Cpf { get; private set; }
        public string NURG { get; private set; }
        public DateTime? DTNASC { get; private set; }

        private ClientePessoaFisica()
        {

        }
    }
}
