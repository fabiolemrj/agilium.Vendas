using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class Cliente: Entidade
    {
        public string CDCLIENTE { get; private set; }
        public string NMCLIENTE { get; private set; }
        public string TPCLIENTE { get; private set; }
        public Int64? IDENDERECO { get; private set; }
        public virtual Endereco Endereco { get; private set; }
        public Int64? IDENDERECOCOB { get; private set; }
        public virtual Endereco EnderecoCobranca { get; private set; }
        public Int64? IDENDERECOFAT { get; private set; }
        public virtual Endereco EnderecoFaturamento { get; private set; }
        public DateTime? DTCAD { get; private set; }
        public int? STCLIENTE { get; private set; }
        public virtual IReadOnlyCollection<ClientePessoaFisica> ClientePessoaFisica { get { return _clientePessoaFisica.ToList(); } }
        private IList<ClientePessoaFisica> _clientePessoaFisica { get; set; }
        public virtual IReadOnlyCollection<ClientePessoaJuridica> ClientePessoaJuridica { get { return _clientePessoaJuridica.ToList(); } }
        private IList<ClientePessoaJuridica> _clientePessoaJuridica { get; set; }
        public virtual IReadOnlyCollection<ClienteContato> ClienteContatos { get { return _clienteContatos.ToList(); } }
        private IList<ClienteContato> _clienteContatos { get; set; }
        public virtual IReadOnlyCollection<ClientePreco> ClientePrecos { get { return _clientePrecos.ToList(); } }
        private IList<ClientePreco> _clientePrecos { get; set; }
        public virtual IReadOnlyCollection<Venda> Venda { get { return _venda.ToList(); } }
        private IList<Venda> _venda { get; set; }
        public virtual IReadOnlyCollection<Vale> Vales { get { return _vales.ToList(); } }
        private IList<Vale> _vales { get; set; }
        public virtual IReadOnlyCollection<VendaTemporaria> VendaTemporaria { get { return _vendaTemporaria.ToList(); } }
        private IList<VendaTemporaria> _vendaTemporaria { get; set; }
        public virtual IReadOnlyCollection<Pedido> Pedidos { get { return _pedidos.ToList(); } }
        private IList<Pedido> _pedidos { get; set; }
        public virtual IReadOnlyCollection<Devolucao> Devolucao { get { return _devolucao.ToList(); } }
        private IList<Devolucao> _devolucao { get; set; }
        public virtual IReadOnlyCollection<ContaReceber> ContaReceber { get { return _contaReceber.ToList(); } }
        private IList<ContaReceber> _contaReceber { get; set; }
        private Cliente()
        {
            _clientePessoaFisica = new List<ClientePessoaFisica>();
            _clientePessoaJuridica = new List<ClientePessoaJuridica>();
            _clienteContatos = new List<ClienteContato>();
            _clientePrecos = new List<ClientePreco>();
            _venda = new List<Venda>();
            _vales = new List<Vale>();
            _vendaTemporaria = new List<VendaTemporaria>();
            _pedidos = new List<Pedido>();
            _devolucao = new List<Devolucao>();
            _contaReceber = new List<ContaReceber>();
        }
        
        
    }
}
