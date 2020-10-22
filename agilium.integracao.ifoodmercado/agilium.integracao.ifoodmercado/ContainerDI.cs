using agilium.integracao.ifoodmercado.dominio.Interfaces.Repositorios;
using agilium.integracao.ifoodmercado.infra.Context;
using agilium.integracao.ifoodmercado.infra.Repositorios;
using agilium.integracao.ifoodmercado.Servico;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado
{
    public class ContainerDI
    {
        public IServiceProvider Build()
        {
            var container = new ServiceCollection();
            container.AddDbContext<dbContextAgilium>(op => { op.UseMySQL("Server = localhost; Database = agilium_fuel; Uid = root; Pwd = 123456;"); });
     
            container.AddScoped<IEnderecoRepositorio, EnderecoRepositorio>();
           // container.AddScoped<ServicoIFoodMercado, ServicoIFoodMercado>();
            //       var serviceProvider = new ServiceCollection()
            //    .AddLogging()
            //    .AddDbContext<dbContextAgilium>(options =>
            //    {
            //        options.UseMySQL("Server = localhost; Database = agilium_fuel; Uid = root; Pwd = 123456;");
            //    })
            //    .AddSingleton<IEmpresaRepositorio, EmpresaRepositorio>()
            //    .AddSingleton<IEnderecoRepositorio, EnderecoRepositorio>()
            //            //.AddScoped<IGrupoProdutoRepositorio, GrupoProdutoRepositorio>()
            //            // .AddScoped<IProdutoComposicaoRepositorio, ProdutoComposicaoRepositorio>()
            //            //  .AddScoped<IProdutoPrecoRepositorio, ProdutoPrecoRepositorio>()
            //            //   .AddScoped<IProdutoRepositorio, ProdutoRepositorio>()
            //            .AddScoped<ServicoIFoodMercado, ServicoIFoodMercado>()
            //.BuildServiceProvider();

            return container.BuildServiceProvider();
        }
    }
}
