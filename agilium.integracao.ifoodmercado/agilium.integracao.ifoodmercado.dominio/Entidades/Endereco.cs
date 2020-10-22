using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using Flunt.Validations;
using System.Text;
using System.Linq;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class Endereco: Entidade
    {
     
        public string Logradouro { get; private set; }
        public string Complemento { get; private set; }
        public string Bairro { get; private set; }
        public string Cep { get; private set; }
        public string Cidade { get; private set; }
        public string Uf { get; private set; }
        public string Pais { get; private set; }
        public int? Ibge { get; private set; }
        public string PontoReferencia { get; private set; }
        public string Numero { get; private set; }
        private IList<EmpresaMysql> _empresa { get; set; }
        public virtual IReadOnlyCollection<EmpresaMysql> Empresas { get { return _empresa.ToList(); } }

        private IList<Cliente> _cliente { get; set; }
        public virtual IReadOnlyCollection<Cliente> Clientes { get { return _cliente.ToList(); } }
        private IList<Cliente> _clienteCobranca { get; set; }
        public virtual IReadOnlyCollection<Cliente> ClientesCobranca { get { return _clienteCobranca.ToList(); } }
        private IList<Cliente> _clienteFaturamento { get; set; }
        public virtual IReadOnlyCollection<Cliente> ClientesFaturamento { get { return _clienteFaturamento.ToList(); } }
        public virtual IReadOnlyCollection<Funcionario> Funcionarios { get { return _funcionarios.ToList(); } }
        private IList<Funcionario> _funcionarios { get; set; }
        public virtual IReadOnlyCollection<Fornecedor> Fornecedor { get { return _fornecedores.ToList(); } }
        private IList<Fornecedor> _fornecedores { get; set; }
        public virtual IReadOnlyCollection<Pedido> Pedidos { get { return _pedidos.ToList(); } }
        private IList<Pedido> _pedidos { get; set; }
        private Endereco()
        {
            _empresa = new List<EmpresaMysql>();
            _cliente = new List<Cliente>();
            _clienteCobranca = new List<Cliente>();
            _clienteFaturamento = new List<Cliente>();
            _funcionarios = new List<Funcionario>();
            _fornecedores = new List<Fornecedor>();
            _pedidos = new List<Pedido>();
        }

    }
}
