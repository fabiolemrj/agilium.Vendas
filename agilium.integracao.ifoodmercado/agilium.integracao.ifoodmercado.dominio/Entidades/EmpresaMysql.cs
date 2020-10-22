using agilium.integracao.ifoodmercado.dominio.ObjetosValor;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class EmpresaMysql: Entidade
    {
        // public Int64 IDEMPRESA { get; private set; }
        public CnpjVO Cnpj { get; private set; }
        public Int64 IDENDERECO { get; private set; }
        public string CDEMPRESA { get; private set; }
        public string NMRZSOCIAL { get; private set; }
        public string NMFANTASIA { get; private set; }
        //public string NUCNPJ { get; private set; }
        public string DSINSCREST { get; private set; }
        public string DSINSCRESTVINC { get; private set; }
        public string DSINSCRMUN { get; private set; }
        public string NMDISTRIBUIDORA { get; private set; }
        public string NUREGJUNTACOM { get; private set; }
        public decimal? NUCAPARM { get; private set; }
        public int? STMICROEMPRESA { get; private set; }
        public int? STLUCROPRESUMIDO { get; private set; }
        public int? TPEMPRESA { get; private set; }
        public int? CRT { get; private set; }
        public string IDCSC { get; private set; }
        public string CSC { get; private set; }
        public string NUCNAE { get; private set; }
        public virtual Endereco Endereco { get; private set; }

        public virtual IReadOnlyCollection<GrupoProduto> GruposProdutos { get { return _grupoProdutos.ToList(); } }
        private IList<GrupoProduto> _grupoProdutos { get; set; }
        public virtual IReadOnlyCollection<Produto> Produtos { get { return _produtos.ToList(); } }
        private IList<Produto> _produtos { get; set; }
        public virtual IReadOnlyCollection<Estoque> Estoque { get { return _estoque.ToList(); } }
        private IList<Estoque> _estoque { get; set; }
        public virtual IReadOnlyCollection<ContatoEmpresa> ContatoEmpresas { get { return _contatoEmpresa.ToList(); } }
        private IList<ContatoEmpresa> _contatoEmpresa { get; set; }
        public virtual IReadOnlyCollection<PontoVenda> PontoVenda { get { return _pontoVenda.ToList(); } }
        private IList<PontoVenda> _pontoVenda { get; set; }
        public virtual IReadOnlyCollection<Caixa> Caixas { get { return _caixas.ToList(); } }
        private IList<Caixa> _caixas { get; set; }
        public virtual IReadOnlyCollection<Moeda> Moedas { get { return _moedas.ToList(); } }
        private IList<Moeda> _moedas { get; set; }
        public virtual IReadOnlyCollection<FormaPagamento> FormaPagamentos { get { return _formaPagamento.ToList(); } }
        private IList<FormaPagamento> _formaPagamento { get; set; }
        public virtual IReadOnlyCollection<Vale> Vales { get { return _vales.ToList(); } }
        private IList<Vale> _vales { get; set; }
        public virtual IReadOnlyCollection<Turno> Turnos { get { return _turno.ToList(); } }
        private IList<Turno> _turno { get; set; }
        public virtual IReadOnlyCollection<Sequencial> Sequencials { get { return _seq.ToList(); } }
        private IList<Sequencial> _seq { get; set; }
        public virtual IReadOnlyCollection<EmpresaAutorizacao> EmpresaAutorizacao { get { return _empresaAut.ToList(); } }
        private IList<EmpresaAutorizacao> _empresaAut { get; set; }
        public virtual IReadOnlyCollection<Funcionario> Funcionarios { get { return _funcionarios.ToList(); } }
        private IList<Funcionario> _funcionarios { get; set; }
        public virtual IReadOnlyCollection<Pedido> Pedidos { get { return _pedidos.ToList(); } }
        private IList<Pedido> _pedidos { get; set; }
        public virtual IReadOnlyCollection<Perda> Perdas { get { return _perda.ToList(); } }
        private IList<Perda> _perda { get; set; }
        public virtual IReadOnlyCollection<PlanoConta> PlanoConta { get { return _planoContas.ToList(); } }
        private IList<PlanoConta> _planoContas { get; set; }
        public virtual IReadOnlyCollection<NotaFiscalInutil> NotaFiscalInutil { get { return _notaFiscalInutil.ToList(); } }
        private IList<NotaFiscalInutil> _notaFiscalInutil { get; set; }
        public virtual IReadOnlyCollection<MotivoDevolucao> MotivoDevolucao { get { return _motivoDevolucao.ToList(); } }
        private IList<MotivoDevolucao> _motivoDevolucao { get; set; }
        public virtual IReadOnlyCollection<Inventario> Inventarios { get { return _inventario.ToList(); } }
        private IList<Inventario> _inventario { get; set; }
        public virtual IReadOnlyCollection<Licenca> Licenca { get { return _licenca.ToList(); } }
        private IList<Licenca> _licenca { get; set; }
        public virtual IReadOnlyCollection<Devolucao> Devolucao { get { return _devolucao.ToList(); } }
        private IList<Devolucao> _devolucao { get; set; }
        public virtual IReadOnlyCollection<ContaReceber> ContaReceber { get { return _contaReceber.ToList(); } }
        private IList<ContaReceber> _contaReceber { get; set; }
        public virtual IReadOnlyCollection<ContaPagar> ContaPagar { get { return _contaPagar.ToList(); } }
        private IList<ContaPagar> _contaPagar { get; set; }
        public virtual IReadOnlyCollection<Configuracao> Configuracao { get { return _configuracao.ToList(); } }
        private IList<Configuracao> _configuracao { get; set; }
        public virtual IReadOnlyCollection<ConfiguracaoCertificado> ConfiguracaoCertificado { get { return _configuracaoCertificado.ToList(); } }
        private IList<ConfiguracaoCertificado> _configuracaoCertificado { get; set; }
        public virtual IReadOnlyCollection<ConfiguracaoImagem> ConfiguracaoImagem { get { return _configuracaoImagem.ToList(); } }
        private IList<ConfiguracaoImagem> _configuracaoImagem { get; set; }
        public virtual IReadOnlyCollection<Compra> Compra { get { return _compra.ToList(); } }
        private IList<Compra> _compra { get; set; }
        private EmpresaMysql()
        {
            _grupoProdutos = new List<GrupoProduto>();
            _produtos = new List<Produto>();
            _estoque = new List<Estoque>();
            _contatoEmpresa = new List<ContatoEmpresa>();
            _pontoVenda = new List<PontoVenda>();
            _caixas = new List<Caixa>();
            _moedas = new List<Moeda>();
            _formaPagamento = new List<FormaPagamento>();
            _vales = new List<Vale>();
            _turno = new List<Turno>();
            _seq = new List<Sequencial>();
            _empresaAut = new List<EmpresaAutorizacao>();
            _funcionarios = new List<Funcionario>();
            _pedidos = new List<Pedido>();
            _perda = new List<Perda>();
            _planoContas = new List<PlanoConta>();
            _notaFiscalInutil = new List<NotaFiscalInutil>();
            _motivoDevolucao = new List<MotivoDevolucao>();
            _inventario = new List<Inventario>();
            _licenca = new List<Licenca>();
            _devolucao = new List<Devolucao>();
            _contaReceber = new List<ContaReceber>();
            _contaPagar = new List<ContaPagar>();
            _configuracao = new List<Configuracao>();
            _configuracaoCertificado = new List<ConfiguracaoCertificado>();
            _configuracaoImagem = new List<ConfiguracaoImagem>();
            _compra = new List<Compra>();
        }

      
    }
}
