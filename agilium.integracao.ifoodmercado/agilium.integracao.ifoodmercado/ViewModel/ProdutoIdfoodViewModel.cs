using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.ViewModel
{
    public class ProdutoIdfoodViewModel
    {
        public int IdLoja { get; set; }
        public string Departamento { get; set; }
        public string Categoria { get; set; }
        public string Subcategoria { get; set; }
        public string Marca { get; set; }
        public string Unidade { get; set; }
        public Int64 CodigoBarra { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public decimal ValorPromocao { get; set; }
        public decimal ValorAtacado { get; set; }
        public decimal ValorCompra { get; set; }
        public decimal QuantidadeEstoqueAtual { get; set; }
        public decimal QuantidadeEstoqueMinimo { get; set; }
        public string Descricao { get; set; }
        public string Ativo { get; set; }
        public int Plu { get; set; }
        public string ValidadeProxima { get; set; }

        public ProdutoIdfoodViewModel()
        {

        }
        public ProdutoIdfoodViewModel(int idLoja, string departamento, string categoria, string subcategoria, string marca, string unidade, Int64 codigoBarra, string nome, decimal valor, decimal valorPromocao, decimal valorAtacado, decimal valorCompra, decimal quantidadeEstoqueAtual, decimal quantidadeEstoqueMinimo, string descricao, string ativo, int plu, string validadeProxima)
        {
            IdLoja = idLoja;
            Departamento = departamento;
            Categoria = categoria;
            Subcategoria = subcategoria;
            Marca = marca;
            Unidade = unidade;
            CodigoBarra = codigoBarra;
            Nome = nome;
            Valor = valor;
            ValorPromocao = valorPromocao;
            ValorAtacado = valorAtacado;
            ValorCompra = valorCompra;
            QuantidadeEstoqueAtual = quantidadeEstoqueAtual;
            QuantidadeEstoqueMinimo = quantidadeEstoqueMinimo;
            Descricao = descricao;
            Ativo = ativo;
            Plu = plu;
            ValidadeProxima = validadeProxima;
        }

    }
}
