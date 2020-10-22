using agilium.integracao.ifoodmercado.dominio.Entidades;
using agilium.integracao.ifoodmercado.dominio.Interfaces.Repositorios;
using agilium.integracao.ifoodmercado.infra.Context;
using agilium.integracao.ifoodmercado.infra.Repositorios;
using agilium.integracao.ifoodmercado.Servico;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.IO;

namespace agilium.integracao.ifoodmercado
{
    public class Program
    {

        public static IConfigurationRoot Configuration { get; set; }
        private static readonly IServiceProvider container = new ContainerDI().Build();


        static void Main(string[] args)
        {

            //var app = new ConfigurationBuilder()
            //                                     .SetBasePath(Directory.GetCurrentDirectory())
            //                                     .AddJsonFile("AppSettings.json")
            //                                     .Build();


           // var serviceProvider = new ServiceCollection()
           //    .AddLogging()
           //    .AddDbContext<dbContextAgilium>(options =>
           //    {
           //        options.UseMySQL("Server = localhost; Database = agilium_fuel; Uid = root; Pwd = 123456;");
           //    })
           //    .AddSingleton<IEmpresaRepositorio, EmpresaRepositorio>()
           //    .AddSingleton<IEnderecoRepositorio, EnderecoRepositorio>()
           //             //.AddScoped<IGrupoProdutoRepositorio, GrupoProdutoRepositorio>()
           //             // .AddScoped<IProdutoComposicaoRepositorio, ProdutoComposicaoRepositorio>()
           //             //  .AddScoped<IProdutoPrecoRepositorio, ProdutoPrecoRepositorio>()
           //             //   .AddScoped<IProdutoRepositorio, ProdutoRepositorio>()
           //            .AddScoped<ServicoIFoodMercado, ServicoIFoodMercado>()
           //.BuildServiceProvider();
                 // var host = builder.Build();

             //var empresaRepositorio = serviceProvider.GetService<IEmpresaRepositorio>();

         //  var repositorio = container.GetService<IEmpresaMySqlRepositorio>();

           // var servico = new ServicoIFoodMercado(repositorio);


         //   servico.ConsultarEmpresa();
            //var serv = new ServicoIFoodMercado();
            //    serv.Teste();
           
           
     
            //var token = servico.EfetuarLogin();
           //servico.EfeutarProduto(token);
           
          //  Console.WriteLine("Hello World!");
        }

   
    }
}
