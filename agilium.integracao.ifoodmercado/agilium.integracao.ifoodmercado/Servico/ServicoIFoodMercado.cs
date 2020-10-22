using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using System.IO;
using agilium.integracao.ifoodmercado.ViewModel;
using System.Net;
using Newtonsoft.Json;
using System.Configuration;
using agilium.integracao.ifoodmercado.dominio.Interfaces.Repositorios;
using System.Threading.Tasks;
using System.Linq;
using agilium.integracao.ifoodmercado.infra.Context;
using agilium.integracao.ifoodmercado.dominio.Entidades;

namespace agilium.integracao.ifoodmercado.Servico
{
    public class ServicoIFoodMercado
    {
        private readonly IEmpresaMySqlRepositorio _empresaRepositorio;
        private readonly IEnderecoRepositorio _enderecoRepositorio;
        private readonly IGrupoProdutoRepositorio _grupoProdutoRepositorio;
        private readonly IProdutoRepositorio _produtoRepositorio;
        private readonly IProdutoComposicaoRepositorio _produtoComposicaoRepositorio;
        private readonly IProdutoFotoRepositorio _produtoFotoRepositorio;
        private readonly IProdutoPrecoRepositorio _produtoPrecoRepositorio;
        private readonly IEstoqueRepositorio _estoqueRepositorio;
        private readonly IContatoRepository _contatoRepository;
        private readonly IContatoEmpresaRepositorio _contatoEmpresaRepositorio;
        private readonly IEstoqueProdutoRepositorio _estoqueProdutoRepositorio;
        private readonly IEstoqueHistoricoRepositorio _estoqueHistoricoRepositorio;
        private readonly IProdutoCodigoBarraRepositorio _produtoCodigoBarraRepositorio;
        private readonly IPontoVendaRepositorio _pontoVendaRepositorio;
        private readonly ICaixaRepositorio _caixaRepositorio;
        private readonly ICaixaMoedaRepositorio _caixaMoedaRepositorio;
        private readonly ICaixaMovimentacaoRepositorio _caixaMovimentacaoRepositorio;
        private readonly IMoedaRepositorio _moedaRepositorio;
        private readonly IClienteRepositorio _clienteRepositorio;
        private readonly IClientePessoaFisicaRepositorio _clientePessoaFisicaRepositorio;
        private readonly IClientePessoaJuridicaRepositorio _clientePessoaJuridicaRepositorio;
        private readonly IClienteContatoRepositorio _clienteContatoRepositorio;
        private readonly IClientePrecoRepositorio _clientePrecoRepositorio;
        private readonly IFormaPagamentoRepositorio _formaPagamentoRepositorio;
        private readonly IVendaRepositorio _vendaRepositorio;
        private readonly IVendaItemRepositorio _vendaItemRepositorio;
        private readonly IVendaMoedaRepositorio _vendaMoedaRepositorio;
        private readonly IVendaCanceladaRepositorio _vendaCanceladaRepositorio;
        private readonly IVendaEspelhoRepositorio _vendaEspelhoRepositorio;
        private readonly IVendaFiscaRepositorio _vendaFiscalRepositorio;
        private readonly IValeRepositorio _valeRepositorio;
        private readonly IVendaTemporariaRepositorio _vendaTemporariaRepositorio;
        private readonly IVendaTemporariaEspelhoRepositorio _vendaTemporariaEspelhoRepositorio;
        private readonly IVendaTemporariaItemRepositorio _vendaTemporariaItemRepositorio;
        private readonly IVendaTemporariaMoedaRepositorio _vendaTemporariaMoedaRepositorio;
        private readonly IUnidadeRepositorio _unidadeRepositorio;
        private readonly ITurnoRepositorio _turnoRepositorio;
        private readonly ITurnoPrecoRepositorio _turnoPrecoRepositorio;
        private readonly ISequencialRepositorio _sequencialRepositorio;
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        private readonly IEmpresaAutorizacaoRepositorio _empresaAutorizacaoRepositorio;
        private readonly IFuncionarioRepositorio _funcionarioRepositorio;
        private readonly IFornecedorRepositorio _fornecedorRepositorio;
        private readonly IFornecedorProdutoRepositorio _fornecedorProdutoRepositorio;
        private readonly IFornecedoreContatoRepositorio _fornecedorContatoRepositorio;
        private readonly IPedidoRepositorio _pedidoRepositorio;
        private readonly IPedidoItemRepositorio _pedidoItemRepositorio;
        private readonly IPedidoItemVendaItemRepositorio _pedidoItemVendaItemRepositorio;
        private readonly IPedidoFormaPagamentoRepositorio _pedidopagamentoRepositorio;
        private readonly IPedidoVendaRepositorio _pedidoVendaRepositorio;
        private readonly IPerdaRepositorio _perdaRepositorio;
        private readonly IPlanoContaRepositorio _planoContaRepositorio;
        private readonly IPlanoContaLancamentoRepositorio _planoContaLancRepositorio;
        private readonly IPlanoContaSaldoRepositorio _planoContaSaldoRepositorio;
        private readonly INcmRepositorio _NcmRepositorio;
        private readonly INotaFiscalInutilRepositorio _notaFiscalRepositorio;
        private readonly IMotivoDevolucaoRepositorio _motivoDevolucaoRepositorio;
        private readonly IInventarioRepositorio _inventarioRepositorio;
        private readonly IInventarioItemRepositorio _inventarioItemRepositorio;
        private readonly IIbptRepositorio _ibptRepositorio;
        private readonly ILicencaRepositorio _licencaRepositorio;
        private readonly ILogSistemaRepositorio _logSistemaRepositorio;
        private readonly ILogErroRepositorio _logErroRepositorio;
        private readonly IDevolucaoRepositorio _devolucaoRepositorio;
        private readonly IDevolucaoItemRepositorio _devolucaoItemRepositorio;
        private readonly ICstRepositorio _cstRepositorio;
        private readonly ICsosnRepositorio _csosnRepositorio;
        private readonly IContasReceberRepositorio _contaReceberRepositorio;
        private readonly ICategFinancRepositorio _categFinancRepositorio;
        private readonly IContaPagarRepositorio _contaPagarRepositorio;
        private readonly IConfiguracaoRepositorio _configuracaoRepositorio;
        private readonly IConfiguracaoCertificadoRepositorio _configuracaoCertificadoRepositorio;
        private readonly IConfiguracaoImagemRepositorio _configuracaoImagemRepositorio;
        private readonly ICompraRepositorio _compraRepositorio;
        private readonly ICompraItemRepositorio _compraItemRepositorio;
        private readonly ICompraFiscalRepositorio _compraFiscalRepositorio;
        private readonly ICidadeRepositorio _cidadeRepositorio;
        private readonly ICepRepositorio _cepRepositorio;
        private readonly ICestNcmRepositorio _cestNcmRepositorio;
        private readonly ICfopRepositorio _cfopRepositorio;

        public ServicoIFoodMercado(IEmpresaMySqlRepositorio empresaRepositorio,
                                    IEnderecoRepositorio enderecoRepositorio,
                                    IGrupoProdutoRepositorio grupoProdutoRepositorio,
                                    IProdutoRepositorio produtoRepositorio,
                                    IProdutoComposicaoRepositorio produtoComposicaoRepositorio,
                                    IProdutoFotoRepositorio produtoFotoRepositorio,
                                    IProdutoPrecoRepositorio produtoPrecoRepositorio,
                                    IEstoqueRepositorio estoqueRepositorio,
                                    IContatoRepository contatoRepository,
                                    IContatoEmpresaRepositorio contatoEmpresaRepositorio,
                                    IEstoqueProdutoRepositorio estoqueProdutoRepositorio,
                                    IEstoqueHistoricoRepositorio estoqueHistoricoRepositorio,
                                    IProdutoCodigoBarraRepositorio produtoCodigoBarraRepositorio,
                                    IPontoVendaRepositorio pontoVendaRepositorio,
                                    ICaixaRepositorio caixaRepositorio,
                                    ICaixaMoedaRepositorio caixaMoedaRepositorio,
                                    ICaixaMovimentacaoRepositorio caixaMovimentacaoRepositorio,
                                    IMoedaRepositorio moedaRepositorio,
                                    IClienteRepositorio clienteRepositorio,
                                    IClientePessoaFisicaRepositorio clientePessoaFisicaRepositorio,
                                    IClientePessoaJuridicaRepositorio clientePessoaJuridicaRepositorio,
                                    IClienteContatoRepositorio clienteContatoRepositorio,
                                    IClientePrecoRepositorio clientePrecoRepositorio,
                                    IFormaPagamentoRepositorio formaPagamentoRepositorio,
                                    IVendaRepositorio vendaRepositorio,
                                    IVendaItemRepositorio vendaItemRepositorio,
                                    IVendaMoedaRepositorio vendaMoedaRepositorio,
                                    IVendaCanceladaRepositorio vendaCanceladaRepositorio,
                                    IVendaEspelhoRepositorio vendaEspelhoRepositorio,
                                    IVendaFiscaRepositorio vendaFiscalRepositorio,
                                    IValeRepositorio valeRepositorio,
                                    IVendaTemporariaRepositorio vendaTemporariaRepositorio,
                                    IVendaTemporariaEspelhoRepositorio vendaTemporariaEspelhoRepositorio,
                                    IVendaTemporariaItemRepositorio vendaTemporariaItemRepositorio,
                                    IVendaTemporariaMoedaRepositorio vendaTemporariaMoedaRepositorio,
                                    IUnidadeRepositorio unidadeRepositorio,
                                    ITurnoRepositorio turnoRepositorio,
                                    ITurnoPrecoRepositorio turnoPrecoRepositorio,
                                    ISequencialRepositorio sequencialRepositorio,
                                    IUsuarioRepositorio usuarioRepositorio,
                                    IEmpresaAutorizacaoRepositorio empresaAutorizacaoRepositorio,
                                    IFuncionarioRepositorio funcionarioRepositorio,
                                    IFornecedorRepositorio fornecedorRepositorio,
                                    IFornecedorProdutoRepositorio fornecedorProdutoRepositorio,
                                    IFornecedoreContatoRepositorio fornecedorContatoRepositorio,
                                    IPedidoRepositorio pedidoRepositorio,
                                    IPedidoItemRepositorio pedidoItemRepositorio,
                                    IPedidoItemVendaItemRepositorio pedidoItemVendaItemRepositorio,
                                    IPedidoFormaPagamentoRepositorio pedidopagamentoRepositorio,
                                    IPedidoVendaRepositorio pedidoVendaRepositorio,
                                    IPerdaRepositorio perdaRepositorio,
                                    IPlanoContaRepositorio planoContaRepositorio,
                                    IPlanoContaLancamentoRepositorio planoContaLancRepositorio,
                                    IPlanoContaSaldoRepositorio planoContaSaldoRepositorio,
                                    INcmRepositorio NcmRepositorio,
                                    INotaFiscalInutilRepositorio notaFiscalRepositorio,
                                    IMotivoDevolucaoRepositorio motivoDevolucaoRepositorio,
                                    IInventarioRepositorio inventarioRepositorio,
                                    IInventarioItemRepositorio inventarioItemRepositorio,
                                    IIbptRepositorio ibptRepositorio,
                                    ILicencaRepositorio licencaRepositorio,
                                    ILogSistemaRepositorio logSistemaRepositorio,
                                    ILogErroRepositorio logErroRepositorio,
                                    IDevolucaoRepositorio devolucaoRepositorio,
                                    IDevolucaoItemRepositorio devolucaoItemRepositorio,
                                    ICstRepositorio cstRepositorio,
                                    ICsosnRepositorio csosnRepositorio,
                                    IContasReceberRepositorio contaReceberRepositorio,
                                    ICategFinancRepositorio categFinancRepositorio,
                                    IContaPagarRepositorio contaPagarRepositorio,
                                    IConfiguracaoRepositorio configuracaoRepositorio,
                                    IConfiguracaoCertificadoRepositorio configuracaoCertificadoRepositorio,
                                    IConfiguracaoImagemRepositorio configuracaoImagemRepositorio,
                                    ICompraRepositorio compraRepositorio,
                                    ICompraItemRepositorio compraItemRepositorio,
                                    ICompraFiscalRepositorio compraFiscalRepositorio,
                                    ICidadeRepositorio cidadeRepositorio,
                                    ICepRepositorio cepRepositorio,
                                    ICestNcmRepositorio cestNcmRepositorio,
                                    ICfopRepositorio cfopRepositorio)
        {
            _empresaRepositorio = empresaRepositorio;
            _enderecoRepositorio = enderecoRepositorio;
            _grupoProdutoRepositorio = grupoProdutoRepositorio;
            _produtoRepositorio = produtoRepositorio;
            _produtoComposicaoRepositorio = produtoComposicaoRepositorio;
            _produtoFotoRepositorio = produtoFotoRepositorio;
            _produtoPrecoRepositorio = produtoPrecoRepositorio;
            _estoqueRepositorio = estoqueRepositorio;
            _contatoRepository = contatoRepository;
            _contatoEmpresaRepositorio = contatoEmpresaRepositorio;
            _estoqueProdutoRepositorio = estoqueProdutoRepositorio;
            _estoqueHistoricoRepositorio = estoqueHistoricoRepositorio;
            _produtoCodigoBarraRepositorio = produtoCodigoBarraRepositorio;
            _pontoVendaRepositorio = pontoVendaRepositorio;
            _caixaRepositorio = caixaRepositorio;
            _caixaMoedaRepositorio = caixaMoedaRepositorio;
            _caixaMovimentacaoRepositorio = caixaMovimentacaoRepositorio;
            _moedaRepositorio = moedaRepositorio;
            _clienteRepositorio = clienteRepositorio;
            _clientePessoaFisicaRepositorio = clientePessoaFisicaRepositorio;
            _clientePessoaJuridicaRepositorio = clientePessoaJuridicaRepositorio;
            _clienteContatoRepositorio = clienteContatoRepositorio;
            _clientePrecoRepositorio = clientePrecoRepositorio;
            _formaPagamentoRepositorio = formaPagamentoRepositorio;
            _vendaRepositorio = vendaRepositorio;
            _vendaItemRepositorio = vendaItemRepositorio;
            _vendaMoedaRepositorio = vendaMoedaRepositorio;
            _vendaCanceladaRepositorio = vendaCanceladaRepositorio;
            _vendaEspelhoRepositorio = vendaEspelhoRepositorio;
            _vendaFiscalRepositorio = vendaFiscalRepositorio;
            _valeRepositorio = valeRepositorio;
            _vendaTemporariaRepositorio = vendaTemporariaRepositorio;
            _vendaTemporariaEspelhoRepositorio = vendaTemporariaEspelhoRepositorio;
            _vendaTemporariaItemRepositorio = vendaTemporariaItemRepositorio;
            _vendaTemporariaMoedaRepositorio = vendaTemporariaMoedaRepositorio;
            _unidadeRepositorio = unidadeRepositorio;
            _turnoRepositorio = turnoRepositorio;
            _turnoPrecoRepositorio = turnoPrecoRepositorio;
            _sequencialRepositorio = sequencialRepositorio;
            _usuarioRepositorio = usuarioRepositorio;
            _empresaAutorizacaoRepositorio = empresaAutorizacaoRepositorio;
            _funcionarioRepositorio = funcionarioRepositorio;
            _fornecedorRepositorio = fornecedorRepositorio;
            _fornecedorProdutoRepositorio = fornecedorProdutoRepositorio;
            _fornecedorContatoRepositorio = fornecedorContatoRepositorio;
            _pedidoRepositorio = pedidoRepositorio;
            _pedidoItemRepositorio = pedidoItemRepositorio;
            _pedidoItemVendaItemRepositorio = pedidoItemVendaItemRepositorio;
            _pedidopagamentoRepositorio = pedidopagamentoRepositorio;
            _pedidoVendaRepositorio = pedidoVendaRepositorio;
            _perdaRepositorio = perdaRepositorio;
            _planoContaRepositorio = planoContaRepositorio;
            _planoContaLancRepositorio = planoContaLancRepositorio;
            _planoContaSaldoRepositorio = planoContaSaldoRepositorio;
            _NcmRepositorio = NcmRepositorio;
            _notaFiscalRepositorio = notaFiscalRepositorio;
            _motivoDevolucaoRepositorio = motivoDevolucaoRepositorio;
            _inventarioRepositorio = inventarioRepositorio;
            _inventarioItemRepositorio = inventarioItemRepositorio;
            _ibptRepositorio = ibptRepositorio;
            _licencaRepositorio = licencaRepositorio;
            _logSistemaRepositorio = logSistemaRepositorio;
            _logErroRepositorio = logErroRepositorio;
            _devolucaoRepositorio = devolucaoRepositorio;
            _devolucaoItemRepositorio = devolucaoItemRepositorio;
            _cstRepositorio = cstRepositorio;
            _csosnRepositorio = csosnRepositorio;
            _contaReceberRepositorio = contaReceberRepositorio;
            _categFinancRepositorio = categFinancRepositorio;
            _contaPagarRepositorio = contaPagarRepositorio;
            _configuracaoRepositorio = configuracaoRepositorio;
            _configuracaoCertificadoRepositorio = configuracaoCertificadoRepositorio;
            _configuracaoImagemRepositorio = configuracaoImagemRepositorio;
            _compraRepositorio = compraRepositorio;
            _compraItemRepositorio = compraItemRepositorio;
            _compraFiscalRepositorio = compraFiscalRepositorio;
            _cidadeRepositorio = cidadeRepositorio;
            _cepRepositorio = cepRepositorio;
            _cestNcmRepositorio = cestNcmRepositorio;
            _cfopRepositorio = cfopRepositorio;
        }

        public ServicoIFoodMercado()
        {
            
        }


        public void Teste()
        {
         

           //try
           // {
           //     using (var context_ = new dbContextAgilium())
           //     {
           //         var lista = context_.Empresas.ToList();
           //     }
                

           // }
           // catch (Exception ex)
           // {
           //     var msg = ex.Message;
           //     throw;
           // }
        }

        public async Task ConsultarEmpresa()
        {
            try
            {
                /* var empresas = await Task.Run(() => _empresaRepositorio.ObterTodos());
                 var endereco = await Task.Run(() => _enderecoRepositorio.ObterTodos());
                 var grupo = await Task.Run(() => _grupoProdutoRepositorio.ObterTodos());
                 var produto = await Task.Run(() => _produtoRepositorio.ObterTodos());
                 var produtoComp = await Task.Run(() => _produtoComposicaoRepositorio.ObterTodos());
                 var produtofoto = await Task.Run(() => _produtoFotoRepositorio.ObterTodos());
                 var produtopreco = await Task.Run(() => _produtoPrecoRepositorio.ObterTodos());
                 var estoque = await Task.Run(() => _estoqueRepositorio.ObterTodos());
                 var contato = await Task.Run(() => _contatoRepository.ObterTodos());
                 var contatoEmpresa = await Task.Run(() => _contatoEmpresaRepositorio.ObterTodos());
                 var estoqueProduto = await Task.Run(() => _estoqueProdutoRepositorio.ObterTodos());
                 var estoqueHistorico = await Task.Run(() => _estoqueHistoricoRepositorio.ObterTodos());
                 var produtoCodigoBarra = await Task.Run(() => _produtoCodigoBarraRepositorio.ObterTodos());
                 var pontoVenda = await Task.Run(() => _pontoVendaRepositorio.ObterTodos());
                 var caixa = await Task.Run(() => _caixaRepositorio.ObterTodos());
                 var caixaMoeda = await Task.Run(() => _caixaMoedaRepositorio.ObterTodos());
                 var caixaMov = await Task.Run(() => _caixaMovimentacaoRepositorio.ObterTodos());
                 var moeda = await Task.Run(() => _moedaRepositorio.ObterTodos());
                 var cliente = await Task.Run(() => _clienteRepositorio.ObterTodos());
                 var clientePF = await Task.Run(() => _clientePessoaFisicaRepositorio.ObterTodos());
                 var clientePJ = await Task.Run(() => _clientePessoaJuridicaRepositorio.ObterTodos());
                 var clienteContato = await Task.Run(() => _clienteContatoRepositorio.ObterTodos());
                 var clientePreco = await Task.Run(() => _clientePrecoRepositorio.ObterTodos());
                 var formaPagamento = await Task.Run(() => _formaPagamentoRepositorio.ObterTodos());
                 var venda = await Task.Run(() => _vendaRepositorio.ObterTodos());
                 var vendaItem = await Task.Run(() => _vendaItemRepositorio.ObterTodos());
                 var vendaMoeda = await Task.Run(() => _vendaMoedaRepositorio.ObterTodos());
                 var vendaCancelada = await Task.Run(() => _vendaCanceladaRepositorio.ObterTodos());
                 var vendaEspelho = await Task.Run(() => _vendaEspelhoRepositorio.ObterTodos());
                 var vendaFiscal = await Task.Run(() => _vendaFiscalRepositorio.ObterTodos());
                 var vale = await Task.Run(() => _valeRepositorio.ObterTodos());
                 var vendaTemporaria = await Task.Run(() => _vendaTemporariaRepositorio.ObterTodos());
                 var vendaTemporariaEspelho = await Task.Run(() => _vendaTemporariaEspelhoRepositorio.ObterTodos());
                 var vendaTemporariaItem = await Task.Run(() => _vendaTemporariaItemRepositorio.ObterTodos());
                 var vendaTemporariaMoeda = await Task.Run(() => _vendaTemporariaMoedaRepositorio.ObterTodos());
                 var unidade = await Task.Run(() => _unidadeRepositorio.ObterTodos());
                 var turno = await Task.Run(() => _turnoRepositorio.ObterTodos());
                 var turnoPreco = await Task.Run(() => _turnoPrecoRepositorio.ObterTodos());
                 var sequencial = await Task.Run(() => _sequencialRepositorio.ObterTodos());
                 var usuario = await Task.Run(() => _usuarioRepositorio.ObterTodos());
                 var empresaAutorizacao = await Task.Run(() => _empresaAutorizacaoRepositorio.ObterTodos());
                 var funcionario = await Task.Run(() => _funcionarioRepositorio.ObterTodos());
                 var fornecedor = await Task.Run(() => _fornecedorRepositorio.ObterTodos());
                 var fornecedorProduto = await Task.Run(() => _fornecedorProdutoRepositorio.ObterTodos());
                 var fornecedorContato = await Task.Run(() => _fornecedorContatoRepositorio.ObterTodos());
                 var pedidoContato = await Task.Run(() => _pedidoRepositorio.ObterTodos());
                 var pedidoItemContato = await Task.Run(() => _pedidoItemRepositorio.ObterTodos());
                 var pedidoItemVendaItemContato = await Task.Run(() => _pedidoItemVendaItemRepositorio.ObterTodos());
                 var pedidopagamento = await Task.Run(() => _pedidopagamentoRepositorio.ObterTodos());
                 var pedidovenda = await Task.Run(() => _pedidoVendaRepositorio.ObterTodos());
                 var perda = await Task.Run(() => _perdaRepositorio.ObterTodos());
                 var planoconta = await Task.Run(() => _planoContaRepositorio.ObterTodos());
                 var planocontalanc = await Task.Run(() => _planoContaLancRepositorio.ObterTodos());
                 var planocontasaldo = await Task.Run(() => _planoContaSaldoRepositorio.ObterTodos());
                 var ncm = await Task.Run(() => _NcmRepositorio.ObterTodos());
                 var notafiscalInutil = await Task.Run(() => _notaFiscalRepositorio.ObterTodos());
                 var motivoDevolucao = await Task.Run(() => _motivoDevolucaoRepositorio.ObterTodos());
                 var inventario = await Task.Run(() => _inventarioRepositorio.ObterTodos());
                var inventarioItem = await Task.Run(() => _inventarioItemRepositorio.ObterTodos());
                var ibpt = await Task.Run(() => _ibptRepositorio.ObterTodos());
                var licenca = await Task.Run(() => _licencaRepositorio.ObterTodos());
                var logsistema = await Task.Run(() => _logSistemaRepositorio.ObterTodos());
                var logErro = await Task.Run(() => _logErroRepositorio.ObterTodos());
                var devolucao = await Task.Run(() => _devolucaoRepositorio.ObterTodos());
                var devolucaoItem = await Task.Run(() => _devolucaoItemRepositorio.ObterTodos());
                var cst = await Task.Run(() => _cstRepositorio.ObterTodos());
                var csosn = await Task.Run(() => _csosnRepositorio.ObterTodos());
                var contaReceber = await Task.Run(() => _contaReceberRepositorio.ObterTodos());
                var categFinanc = await Task.Run(() => _categFinancRepositorio.ObterTodos());
                var contaPagar = await Task.Run(() => _contaPagarRepositorio.ObterTodos());
                var config = await Task.Run(() => _configuracaoRepositorio.ObterTodos());
                var configCertificado = await Task.Run(() => _configuracaoCertificadoRepositorio.ObterTodos());
                var configImagem = await Task.Run(() => _configuracaoImagemRepositorio.ObterTodos());
                var compra = await Task.Run(() => _compraRepositorio.ObterTodos());
                var compraItem = await Task.Run(() => _compraItemRepositorio.ObterTodos());
                var compraFiscal = await Task.Run(() => _compraFiscalRepositorio.ObterTodos());
                var cidade = await Task.Run(() => _cidadeRepositorio.ObterTodos());
                var cep = await Task.Run(() => _cepRepositorio.ObterTodos());
                var cestNcm = await Task.Run(() => _cestNcmRepositorio.ObterTodos());*/
                var cfop = await Task.Run(() => _cfopRepositorio.ObterTodos());
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
                throw;
            }
          
        }
        public static IConfigurationRoot Configuration { get; set; }
        public string EfetuarLogin()
        {

            var resultado = string.Empty;


            var url = "https://service.sitemercado.com.br/api/v1/oauth/token";
            var client_id = "7d347dd1-a70e-4526-878b-83ed2e7210a5";
            var cliente_secrete = "pJa-EG7cMe3_H.U.YNRu_6j73436R1Hc0S";

            var autenticacaovViewModel = new AutenticacaoViewModel(client_id, cliente_secrete);

            var autenticacaoViewModelSerializado = JsonConvert.SerializeObject(autenticacaovViewModel);

            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest(Method.POST);
            //request.AddHeader("Postman-Token", "6db735fc-fd7f-ec6f-3d81-b84dde5e68a8");
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", autenticacaoViewModelSerializado, ParameterType.RequestBody);

            IRestResponse response = client.Execute(request);

            RetornoAutenticacaoViewModel retornoaut = JsonConvert.DeserializeObject<RetornoAutenticacaoViewModel>(response.Content.ToString()); ;

            if (response.StatusCode == HttpStatusCode.OK)
            {
                resultado = retornoaut.Access_token;
            }

            return resultado; ;
        }

        public bool AdicionarProdutos(string token, List<ProdutoIdfoodViewModel> lista) {

            var resultado = false;
            var url = "https://service.sitemercado.com.br/api/v1/produtointegracao";

            /*
             * "idLoja": 001,
    "departamento": "PERECIVEIS", 
    "categoria": "FRIOS",
    "subCategoria": "APRESUNTADO",
    "marca": "SADIA",
    "unidade": "KG",
    "volume": "1KG",
    "codigoBarra": "7891231231231",
    "nome": "APRESENTURADO SADIA 1KG",
    "valor": 19.99,
    "valorPromocao": 14.99,
    "valorAtacado": 0,
    "valorCompra": 0,
    "quantidadeEstoqueAtual": 5.492, 
    "quantidadeEstoqueMinimo": 0,
    "quantidadeAtacado": 0,
    "descricao": "APRESENTURADO SADIA 1KG",
    "ativo": true,
    "plu": "101010",
    "validadeProxima": false
                */

            //var produtoIFood = new ProdutoIdfoodViewModel(6471, "PERECIVEIS", "FRIOS", "APRESUNTADO", "SADIA", "KG", 7891231231231,
            //    "APRESENTURADO SADIA 1KG",10-.92m,14.99m,0
            //    ,0,0,0, "APRESENTURADO SADIA 1KG","false", 101010,"false");
            // var lista = new List<ProdutoIdfoodViewModel>();
            // lista.Add(produtoIFood);
            var produtoIfoodSerializado = JsonConvert.SerializeObject(lista);

            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest(Method.POST);
            //request.AddHeader("Postman-Token", "6db735fc-fd7f-ec6f-3d81-b84dde5e68a8");
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", "Bearer " + token);
            request.AddParameter("application/json", produtoIfoodSerializado, ParameterType.RequestBody);

            IRestResponse response = client.Execute(request);

            if (response.StatusCode == HttpStatusCode.OK)
                resultado = true;

            return resultado;
        }

        public bool ObterTodosEventos(string token)
        {
            
            var resultado = false;
            var url = "https://service.sitemercado.com.br/api/v1/pedido/eventos";

            /*
            Retorna os eventos
                A chamada / api / v1 / pedido / eventos trás todos os eventos dos pedidos da rede de lojas com
                       seus status, por exemplo, se uma rede de lojas possui mais que uma loja cadastrada no nosso
                sistema essa chamada trará todos os eventos
                */
            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest(Method.GET);
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", "Bearer " + token);

            IRestResponse response = client.Execute(request);

            if (response.StatusCode == HttpStatusCode.OK)
                resultado = true;

            return resultado;
        }

        public bool ObterEventosPorLoja(string token, int idloja)
        {
            var resultado = false;
            var url = $@"https://service.sitemercado.com.br/api/v1/pedido/eventos/{idloja}";

            /*
            Retorna os eventos
                A chamada / api / v1 / pedido / eventos trás todos os eventos dos pedidos da rede de lojas com
                       seus status, por exemplo, se uma rede de lojas possui mais que uma loja cadastrada no nosso
                sistema essa chamada trará todos os eventos
                */
            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest(Method.GET);
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", "Bearer " + token);

            IRestResponse response = client.Execute(request);

            if (response.StatusCode == HttpStatusCode.OK)
                resultado = true;

            return resultado;
        }

        public bool ObterEventoVerificado(string token, string idevento)
        {
            var resultado = false;
            var url = $@"https://service.sitemercado.com.br/api/v1/pedido/eventos/verificado";

            /*
            Chamada de evento verificado:
A chamada retira o “evento” das chamadas de eventos, envie o id do evento no body da
requisição e o mesmo não retornara mais.
                */
            var eventoViewModel = new EventoViewModel();
            eventoViewModel.idevento = idevento;
            var objetoSerializado = JsonConvert.SerializeObject(eventoViewModel);

            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest(Method.POST);
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", "Bearer " + token);
            request.AddParameter("application/json", objetoSerializado, ParameterType.RequestBody);

            IRestResponse response = client.Execute(request);

            if (response.StatusCode == HttpStatusCode.OK)
                resultado = true;

            return resultado;
        }

        public bool ObterPedidoPorCodigo(string token, int idpedido)
        {
            
            var resultado = false;
            var url = $@"https://service.sitemercado.com.br/api/v1/pedido/cod_pedido/{idpedido}";

            /*Retorna um pedido de acordo com o código informado
Este evento retorna o status do pedido de acordo com o código informado
*/

            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest(Method.GET);
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", "Bearer " + token);

            IRestResponse response = client.Execute(request);

            if (response.StatusCode == HttpStatusCode.OK)
                resultado = true;

            return resultado;
        }

        public bool AlteraSituacaoProdutoSeparacao(string token, int idpedido, AlteraStatusSeparacaoViewModel model)
        {
            var resultado = false;
            var url = $@"https://service.sitemercado.com.br/api/v1/pedido/cod_pedido/status/em_separacao/{idpedido}";

            /*
           Indica que o pedido irá entrar em separação
Este evento altera o status do pedido para separado.
                */
            var eventoViewModel = new EventoViewModel();
            var objetoSerializado = JsonConvert.SerializeObject(model);

            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest(Method.PUT);
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", "Bearer " + token);
            request.AddParameter("application/json", objetoSerializado, ParameterType.RequestBody);

            IRestResponse response = client.Execute(request);

            if (response.StatusCode == HttpStatusCode.OK)
                resultado = true;

            return resultado;
        }

        public bool AlteraSituacaoProdutoFinalizar(string token, int idpedido)
        {
            var resultado = false;
            var url = $@"https://service.sitemercado.com.br/api/v1/pedido/cod_pedido/status/concluido/{idpedido}";

            /*
   Responsável por finalizar o pedido
Indica que o Pedido foi entregue ou retirado pelo cliente na loja.
                */
            var eventoViewModel = new EventoViewModel();


            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest(Method.PUT);
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", "Bearer " + token);

            IRestResponse response = client.Execute(request);

            if (response.StatusCode == HttpStatusCode.OK)
                resultado = true;

            return resultado;
        }

        public bool CancelarPedido(string token, int idpedido, string mensagemCancelamento)
        {
            var resultado = false;
            var url = $@"https://service.sitemercado.com.br/api/v1/pedido/cod_pedido/status/cancelar/{idpedido}";

            /*
  Responsável por cancelar um Pedido
O Cancelamento pode ser realizado em qualquer etapa do pedido, menos após ser finalizado.
Os items do pedido irão retornar para o carrinho do cliente que realizou o pedido.
                */
            var eventoViewModel = new EventoViewModel();

            var objeto = new { mensagem = mensagemCancelamento };
            var objetoSerializado = JsonConvert.SerializeObject(objeto);

            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest(Method.PUT);
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", "Bearer " + token);
            request.AddParameter("application/json", objetoSerializado, ParameterType.RequestBody);

            IRestResponse response = client.Execute(request);

            if (response.StatusCode == HttpStatusCode.OK)
                resultado = true;

            return resultado;
        }

        public bool MarcaPedidoCancelado(string token, int idpedido, string mensagemCancelamento)
        {
            var resultado = false;
            var url = $@"https://service.sitemercado.com.br/api/v1/pedido/cod_pedido/status/em_devolucao/{idpedido}";

            /*
Marca que o pedido será cancelado
por esse motivo os produtos estão em devolução para prateleira.
                */
         
            var objeto = new { mensagem = mensagemCancelamento };
            var objetoSerializado = JsonConvert.SerializeObject(objeto);

            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest(Method.PUT);
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", "Bearer " + token);
            request.AddParameter("application/json", objetoSerializado, ParameterType.RequestBody);

            IRestResponse response = client.Execute(request);

            if (response.StatusCode == HttpStatusCode.OK)
                resultado = true;

            return resultado;
        }

        public bool ObterItensPedido(string token, int idpedido)
        {

            var resultado = false;
            var url = $@"https://service.sitemercado.com.br/api/v1/pedido/cod_pedido/items/{idpedido}";

            /*Consultar itens do pedido
Esse endpoint retorna todos os itens de um pedido
*/

            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest(Method.GET);
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", "Bearer " + token);

            IRestResponse response = client.Execute(request);

            if (response.StatusCode == HttpStatusCode.OK)
                resultado = true;

            return resultado;
        }
    }
}
