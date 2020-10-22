using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using agilium.integracao.ifoodmercado.dominio.Entidades;
using agilium.integracao.ifoodmercado.dominio.Interfaces.Repositorios;
using agilium.integracao.ifoodmercado.infra.Context;
using agilium.integracao.ifoodmercado.infra.MapeamentoEF;
using agilium.integracao.ifoodmercado.infra.Repositorios;
using agilium.integracao.ifoodmercado.Servico;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;


namespace WebTeste
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
      
            services.AddDbContext<dbContextAgilium>(op => { op.UseMySQL("Server = localhost; Database = happy; Uid = root; Pwd = 123456;"); });
            services.AddScoped<IEmpresaMySqlRepositorio, EmpresaMySqlRepositorio>();
            services.AddScoped<IEnderecoRepositorio, EnderecoRepositorio>();
            services.AddScoped<IGrupoProdutoRepositorio, GrupoProdutoRepositorio>();
            services.AddScoped<IProdutoRepositorio, ProdutoRepositorio>();
            services.AddScoped<IProdutoComposicaoRepositorio, ProdutoComposicaoRepositorio>();
            services.AddScoped<IProdutoFotoRepositorio, ProdutoFotoRepositorio>();
            services.AddScoped<IProdutoPrecoRepositorio, ProdutoPrecoRepositorio>();
            services.AddScoped<IEstoqueRepositorio, EstoqueRepositorio>();
            services.AddScoped<IContatoEmpresaRepositorio, ContatoEmpresaRepositorio>();
            services.AddScoped<IContatoRepository, ContatoRepository>();
            services.AddScoped<IEstoqueProdutoRepositorio, EstoqueProdutoRepositorio>();
            services.AddScoped<IEstoqueHistoricoRepositorio, EstoqueHistoricoRepositorio>();
            services.AddScoped<IProdutoCodigoBarraRepositorio, ProdutoCodigoBarraRepositorio>();
            services.AddScoped<IPontoVendaRepositorio, PontoVendaRepositorio>();
            services.AddScoped<ICaixaRepositorio, CaixaRepositorio>();
            services.AddScoped<ICaixaMoedaRepositorio, CaixaMoedaRepositorio>();
            services.AddScoped<ICaixaMovimentacaoRepositorio, CaixaMovimentacaoRepositorio>();
            services.AddScoped<IMoedaRepositorio, MoedaRepositorio>();
            services.AddScoped<IClienteRepositorio, ClienteRepositorio>();
            services.AddScoped<IClientePessoaFisicaRepositorio, ClientePessoaFisicaRepositorio>();
            services.AddScoped<IClientePessoaJuridicaRepositorio, ClientePessoaJuridicaRepositorio>();
            services.AddScoped<IClienteContatoRepositorio, ClienteContatoRepositorio>();
            services.AddScoped<IClientePrecoRepositorio, ClientePrecoRepositorio>();
            services.AddScoped<IFormaPagamentoRepositorio, FormaPagamentoRepositorio>();
            services.AddScoped<IVendaRepositorio, VendaRepositorio>();
            services.AddScoped<IVendaItemRepositorio, VendaItemRepositorio>();
            services.AddScoped<IVendaMoedaRepositorio, VendaMoedaRepositorio>();
            services.AddScoped<IVendaCanceladaRepositorio, VendaCanceladaRepositorio>();
            services.AddScoped<IVendaEspelhoRepositorio, VendaEspelhoRepositorio>();
            services.AddScoped<IVendaFiscaRepositorio, VendaFiscalRepositorio>();
            services.AddScoped<IValeRepositorio, ValeRepositorio>();
            services.AddScoped<IVendaTemporariaRepositorio, VendaTemporariaRepositorio>();
            services.AddScoped<IVendaTemporariaEspelhoRepositorio, VendaTemporariaEspelhoRepositorio>();
            services.AddScoped<IVendaTemporariaItemRepositorio, VendaTemporariaItemRepositorio>();
            services.AddScoped<IVendaTemporariaMoedaRepositorio, VendaTemporariaMoedaRepositorio>();
            services.AddScoped<IUnidadeRepositorio, UnidadeRepositorio>();
            services.AddScoped<ITurnoRepositorio, TurnoRepositorio>();
            services.AddScoped<ITurnoPrecoRepositorio, TurnoPrecoRepositorio>();
            services.AddScoped<ISequencialRepositorio, SequencialRepositorio>();
            services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();
            services.AddScoped<IEmpresaAutorizacaoRepositorio, EmpresaAutorizacaoRepositorio>();
            services.AddScoped<IFuncionarioRepositorio, FuncionarioRepositorio>();
            services.AddScoped<IFornecedorRepositorio, FornecedorRepositorio>();
            services.AddScoped<IFornecedorProdutoRepositorio, FornecedorProdutoRepositorio>();
            services.AddScoped<IFornecedoreContatoRepositorio, FornecedorContatoRepositorio>();
            services.AddScoped<IPedidoRepositorio, PedidoRepositorio>();
            services.AddScoped<IPedidoItemRepositorio, PedidoItemRepositorio>();
            services.AddScoped<IPedidoItemVendaItemRepositorio, PedidoItemVendaItemRepositorio>();
            services.AddScoped<IPedidoFormaPagamentoRepositorio, PedidoPagamentoRepositorio>();
            services.AddScoped<IPedidoVendaRepositorio, PedidoVendaRepositorio>();
            services.AddScoped<IPerdaRepositorio, PerdaRepositorio>();
            services.AddScoped<IPlanoContaRepositorio, PlanoContaRepositorio>();
            services.AddScoped<IPlanoContaLancamentoRepositorio, PlanoContaLancamentoRepositorio>();
            services.AddScoped<IPlanoContaSaldoRepositorio, PlanoContaSaldoRepositorio>();
            services.AddScoped<INcmRepositorio, NcmRepositorio>();
            services.AddScoped<INotaFiscalInutilRepositorio, NotaFiscalInutilRepositorio>();
            services.AddScoped<IMotivoDevolucaoRepositorio, MotivoDevolucaoRepositorio>();
            services.AddScoped<IInventarioRepositorio, InventarioRepositorio>();
            services.AddScoped<IInventarioItemRepositorio, InventarioItemRepositorio>();
            services.AddScoped<IIbptRepositorio, IbptRepositorio>();
            services.AddScoped<IIbptRepositorio, IbptRepositorio>();
            services.AddScoped<ILicencaRepositorio, LicencaRepositorio>();
            services.AddScoped<ILogSistemaRepositorio, LogSistemaRepositorio>();
            services.AddScoped<ILogErroRepositorio, LogErroRepositorio>();
            services.AddScoped<IDevolucaoRepositorio, DevolucaoRepositorio>();
            services.AddScoped<IDevolucaoItemRepositorio, DevolucaoItemRepositorio>();
            services.AddScoped<ICstRepositorio, CstRepositorio>();
            services.AddScoped<ICsosnRepositorio, CsonsRepositorio>();
            services.AddScoped<IContasReceberRepositorio, ContaReceberRepositorio>();
            services.AddScoped<ICategFinancRepositorio, CategFinancRepositorio>();
            services.AddScoped<IContaPagarRepositorio, ContaPagarRepositorio>();
            services.AddScoped<IConfiguracaoRepositorio, ConfiguracaoRepositorio>();
            services.AddScoped<IConfiguracaoCertificadoRepositorio, ConfiguracaoCertificadoRepositorio>();
            services.AddScoped<IConfiguracaoImagemRepositorio, ConfiguracaoImagemRepositorio>();
            services.AddScoped<ICompraRepositorio, CompraRepositorio>();
            services.AddScoped<ICompraItemRepositorio, CompraItemRepositorio>();
            services.AddScoped<ICompraFiscalRepositorio, CompraFiscalRepositorio>();
            services.AddScoped<ICidadeRepositorio, CidadeRepositorio>();
            services.AddScoped<ICepRepositorio, CepRepositorio>();
            services.AddScoped<ICestNcmRepositorio, CestNcmRepositorio>();
            services.AddScoped<ICfopRepositorio, CfopRepositorio>();

            services.AddScoped<ServicoIFoodMercado, ServicoIFoodMercado>();
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
