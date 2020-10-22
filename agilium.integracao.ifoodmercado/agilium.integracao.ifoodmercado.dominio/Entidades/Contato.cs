using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class Contato: Entidade
    {
        public int TPCONTATO { get; private set; }
        public string DESCR1 { get; private set; }
        public string DESCR2 { get; private set; }
        public virtual IReadOnlyCollection<ContatoEmpresa> ContatoEmpresas { get { return _contatoEmpresa.ToList(); } }
        private IList<ContatoEmpresa> _contatoEmpresa { get; set; }
        public virtual IReadOnlyCollection<ClienteContato> ClienteContatos { get { return _clienteContatos.ToList(); } }
        private IList<ClienteContato> _clienteContatos { get; set; }
        public virtual IReadOnlyCollection<FornecedorContato> FornecedorContato{ get { return _fornecedorContato.ToList(); } }
        private IList<FornecedorContato> _fornecedorContato { get; set; }
        private Contato()
        {
            _contatoEmpresa = new List<ContatoEmpresa>();
            _clienteContatos = new List<ClienteContato>();
            _fornecedorContato = new List<FornecedorContato>();
        }
         
    }
}
