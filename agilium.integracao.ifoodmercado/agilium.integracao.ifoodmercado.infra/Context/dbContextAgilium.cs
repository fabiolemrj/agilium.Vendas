using agilium.integracao.ifoodmercado.dominio.Entidades;
using agilium.integracao.ifoodmercado.dominio.Interfaces.Repositorios;
using agilium.integracao.ifoodmercado.infra.MapeamentoEF;
using Flunt.Notifications;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient.Memcached;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.infra.Context
{
    public class dbContextAgilium : DbContext
    {

        public dbContextAgilium(DbContextOptions<dbContextAgilium> options) : base(options)
        {
        }

        public DbSet<EmpresaMysql> EmpresasMysql { get; set; }
        // public DbSet<Empresa> Empresas { get; set; }
          public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<GrupoProduto> GrupoProdutos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<ProdutoComposicao> ProdutosComposicao { get; set; }
        public DbSet<ProdutoPreco> ProdutoPreco { get; set; }
        public DbSet<ProdutoFoto> ProdutoFoto { get; set; }
        public DbSet<Estoque> Estoque { get; set; }
        public DbSet<Contato> Contatos { get; set; }
        public DbSet<ContatoEmpresa> ContatosEmpresa { get; set; }
        public DbSet<EstoqueProduto> EstoqueProdutos { get; set; }
        public DbSet<EstoqueHistorico> EstoqueHistorico { get; set; }
        public DbSet<ProdutoCodigoBarra> ProdutoCodigoBarra { get; set; }
        public DbSet<PontoVenda> PontoVenda { get; set; }
        public DbSet<Caixa> Caixa { get; set; }
        public DbSet<CaixaMoeda> CaixaMoeda { get; set; }
        public DbSet<CaixaMovimentacao> CaixaMovimentacao { get; set; }
        public DbSet<Moeda> Moeda { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<ClientePessoaFisica> ClientePessoaFisica { get; set; }
        public DbSet<ClientePessoaJuridica> ClientePessoaJuridica { get; set; }
        public DbSet<ClienteContato> ClienteContato { get; set; }
        public DbSet<ClientePreco> ClientePreco { get; set; }
        public DbSet<FormaPagamento> FormaPagamento { get; set; }
        public DbSet<Venda> Venda { get; set; }
        public DbSet<VendaItem> VendaItem { get; set; }
        public DbSet<VendaMoeda> VendaMoeda { get; set; }
        public DbSet<VendaCancelada> VendaCancelada { get; set; }
        public DbSet<VendaEspelho> VendaEspelhos { get; set; }
        public DbSet<VendaFiscal> VendaFiscal { get; set; }
        public DbSet<Vale> Vale { get; set; }
        public DbSet<VendaTemporaria> VendaTemporaria { get; set; }
        public DbSet<VendaTemporariaEspelho> VendaTemporariaEspelho { get; set; }
        public DbSet<VendaTemporariaItem> VendaTemporariaItem { get; set; }
        public DbSet<VendaTemporariaMoeda> VendaTemporariaMoeda { get; set; }
        public DbSet<Unidade> Unidades { get; set; }
        public DbSet<Turno> Turnos { get; set; }
        public DbSet<TurnoPreco> TurnoPreco { get; set; }
        public DbSet<Sequencial> Sequencial { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<EmpresaAutorizacao> EmpresaAutorizacao { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<FornecedorProduto> FornecedorProduto { get; set; }
        public DbSet<FornecedorContato> FornecedorContato { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<PedidoItem> PedidoItem { get; set; }
        public DbSet<PedidoItemVendaItem> PedidoItemVendaItem { get; set; }
        public DbSet<PedidoPagamento> PedidoPagamento { get; set; }
        public DbSet<PedidoVenda> PedidoVenda { get; set; }
        public DbSet<Perda> Perda { get; set; }
        public DbSet<PlanoConta> PlanoContas { get; set; }
        public DbSet<PlanoContaLancamento> PlanoContaLancamento { get; set; }
        public DbSet<PlanoContaSaldo> PlanoContaSaldo { get; set; }
        public DbSet<Ncm> Ncm { get; set; }
        public DbSet<NotaFiscalInutil> NotaFiscalInutil { get; set; }
        public DbSet<MotivoDevolucao> MotivoDevolucao { get; set; }
        public DbSet<Inventario> Inventario { get; set; }
        public DbSet<InventarioItem> InventarioItem { get; set; }
        public DbSet<Ibpt> Ibpt { get; set; }
        public DbSet<Licenca> Licenca { get; set; }
        public DbSet<LogSistema> LogSistema { get; set; }
        public DbSet<LogErro> LogErro { get; set; }
        public DbSet<Devolucao> Devolucao { get; set; }
        public DbSet<DevolucaoItem> DevolucaoItem { get; set; }
        public DbSet<Cst> Cst { get; set; }
        public DbSet<Csosn> Csosn { get; set; }
        public DbSet<ContaReceber> ContaReceber { get; set; }
        public DbSet<CategFinanc> CategFinanc { get; set; }
        public DbSet<ContaPagar> ContaPagar { get; set; }
        public DbSet<Configuracao> Configuracao { get; set; }
        public DbSet<ConfiguracaoCertificado> ConfiguracaoCertificado { get; set; }
        public DbSet<ConfiguracaoImagem> ConfiguracaoImagem { get; set; }
        public DbSet<Compra> Compra { get; set; }
        public DbSet<CompraItem> CompraItem { get; set; }
        public DbSet<CompraFiscal> CompraFiscal { get; set; }
        //mapping
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<Notification>();

            modelBuilder.ApplyConfiguration(new EmpresaMySqlMapeamento());
            modelBuilder.ApplyConfiguration(new EstoqueMapeamento());
            modelBuilder.ApplyConfiguration(new EnderecoMapeamento());
            modelBuilder.ApplyConfiguration(new GrupoProdutoMapeamento());
            modelBuilder.ApplyConfiguration(new ProdutoComposicaoMapeamento());
            modelBuilder.ApplyConfiguration(new ProdutoFotoMapeamento());
            modelBuilder.ApplyConfiguration(new ProdutoPrecoMapeamento());
            modelBuilder.ApplyConfiguration(new ProdutoMapeamento());
            modelBuilder.ApplyConfiguration(new ContatoMapeamento());
            modelBuilder.ApplyConfiguration(new ContatoEmpresaMapeamento());
            modelBuilder.ApplyConfiguration(new EstoqueProdutoMapeamento());
            modelBuilder.ApplyConfiguration(new EstoqueHistoricoMapeamento());
            modelBuilder.ApplyConfiguration(new ProdutoCodigoBarraMapeamento());
            modelBuilder.ApplyConfiguration(new PontoVendaMapeamento());
            modelBuilder.ApplyConfiguration(new CaixaMapeamento());
            modelBuilder.ApplyConfiguration(new CaixaMoedaMapeamento());
            modelBuilder.ApplyConfiguration(new CaixaMovimentacaoMapeamento());
            modelBuilder.ApplyConfiguration(new MoedaMapeamento());
            modelBuilder.ApplyConfiguration(new ClienteMapeamento());
            modelBuilder.ApplyConfiguration(new ClientePessoaFisicaMapeamento());
            modelBuilder.ApplyConfiguration(new ClientePessoaJuridicaMapeamento());
            modelBuilder.ApplyConfiguration(new ClienteContatoMapeamento());
            modelBuilder.ApplyConfiguration(new ClientePrecoMapeamento());
            modelBuilder.ApplyConfiguration(new FormaPagamentoMapeamento());
            modelBuilder.ApplyConfiguration(new VendaMapeamento());
            modelBuilder.ApplyConfiguration(new VendaItemMapeamento());
            modelBuilder.ApplyConfiguration(new VendaMoedaMapeamento());
            modelBuilder.ApplyConfiguration(new VendaCanceladaMapeamento());
            modelBuilder.ApplyConfiguration(new VendaEspelhoMapeamento());
            modelBuilder.ApplyConfiguration(new VendaFiscalMapeamento());
            modelBuilder.ApplyConfiguration(new ValeMapeamento());
            modelBuilder.ApplyConfiguration(new VendaTemporariaMapeamento());
            modelBuilder.ApplyConfiguration(new VendaTemporariaEspelhoMapeamento());
            modelBuilder.ApplyConfiguration(new VendaTemporariaItemMapeamento());
            modelBuilder.ApplyConfiguration(new VendaTemporariaMoedaMapeamento());
            modelBuilder.ApplyConfiguration(new UnidadeMapeamento());
            modelBuilder.ApplyConfiguration(new TurnoMapeamento());
            modelBuilder.ApplyConfiguration(new TurnoPrecoMapeamento());
            modelBuilder.ApplyConfiguration(new SequencialMapeamento());
            modelBuilder.ApplyConfiguration(new UsuarioMapeamento());
            modelBuilder.ApplyConfiguration(new EmpresaAutorizacaoMapeamento());
            modelBuilder.ApplyConfiguration(new FuncionarioMapeamento());
            modelBuilder.ApplyConfiguration(new FornecedorMapeamento());
            modelBuilder.ApplyConfiguration(new FornecedorProdutoMapeamento());
            modelBuilder.ApplyConfiguration(new FornecedorContatoMapeamento());
            modelBuilder.ApplyConfiguration(new PedidoMapeamento());
            modelBuilder.ApplyConfiguration(new PedidoItemMapeamento());
            modelBuilder.ApplyConfiguration(new PedidoItemVendaItemMapeamento());
            modelBuilder.ApplyConfiguration(new PedidoPagamentoMapeamento());
            modelBuilder.ApplyConfiguration(new PedidoVendaMapeamento());
            modelBuilder.ApplyConfiguration(new PerdaMapeamento());
            modelBuilder.ApplyConfiguration(new PlanoContaMapeamento());
            modelBuilder.ApplyConfiguration(new PlanoContaLancamentoMapeamento());
            modelBuilder.ApplyConfiguration(new PlanoContaSaldoMapeamento());
            modelBuilder.ApplyConfiguration(new NcmMapeamento());
            modelBuilder.ApplyConfiguration(new NotaFiscalInutilMapeamento());
            modelBuilder.ApplyConfiguration(new MotivoDevolucaoMapeamento());
            modelBuilder.ApplyConfiguration(new InventarioMapeamento());
            modelBuilder.ApplyConfiguration(new InventarioItemMapeamento());
            modelBuilder.ApplyConfiguration(new IbptMapeamento());
            modelBuilder.ApplyConfiguration(new LicencaMapeamento());
            modelBuilder.ApplyConfiguration(new LogSistemaMapeamento());
            modelBuilder.ApplyConfiguration(new LogErroMapeamento());
            modelBuilder.ApplyConfiguration(new DevolucaoMapeamento());
            modelBuilder.ApplyConfiguration(new DevolucaoItemMapeamento());
            modelBuilder.ApplyConfiguration(new CstMapeamento());
            modelBuilder.ApplyConfiguration(new CsosnMapeamento());
            modelBuilder.ApplyConfiguration(new ContaReceberMapeamento());
            modelBuilder.ApplyConfiguration(new CategFinancMapeamento());
            modelBuilder.ApplyConfiguration(new ContaPagarMapeamento());
            modelBuilder.ApplyConfiguration(new ConfiguracaoMapeamento());
            modelBuilder.ApplyConfiguration(new ConfiguracaoCertificadoMapeamento());
            modelBuilder.ApplyConfiguration(new ConfiguracaoImagemMapeamento());
            modelBuilder.ApplyConfiguration(new CompraMapeamento());
            modelBuilder.ApplyConfiguration(new CompraItemMapeamento());
            modelBuilder.ApplyConfiguration(new CompraFiscalMapeamento());
        }
    }
}
