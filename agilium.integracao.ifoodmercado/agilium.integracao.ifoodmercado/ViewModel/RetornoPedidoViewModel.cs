using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace agilium.integracao.ifoodmercado.ViewModel
{
    public class RetornoPedidoViewModel
    {
        public Pedido pedido { get; set; }
        public Plataforma plataforma { get; set; }
        public EnderecoEntrega enderecoEntrega { get; set; }
        public Loja loja { get; set; }
        public Rede rede { get; set; }
        public Cliente cliente { get; set; }
        public List<ItemPedido> Items { get; set; }
        public  List<Pagamento> pagamentos{ get; set; }
        public RetornoPedidoViewModel()
        {
            Items = new List<ItemPedido>();
            pagamentos = new List<Pagamento>();
        }

        public RetornoPedidoViewModel(Pedido pedido, Plataforma plataforma, EnderecoEntrega enderecoEntrega, Loja loja, Rede rede, Cliente cliente)
        {
            Items = new List<ItemPedido>();
            pagamentos = new List<Pagamento>();

            this.pedido = pedido;
            this.plataforma = plataforma;
            this.enderecoEntrega = enderecoEntrega;
            this.loja = loja;
            this.rede = rede;
            this.cliente = cliente;     
        }
    }

    public class Pedido
    {
        public int idLoja { get; set; }// CÓDIGO ID LOJA
        public int idCliente { get; set; }  // CODIGO DO CLIENTE
        public string codigo { get; set; } // CODIGO FICHA DO PEDIDO NO SITE MERCADO
        public string codigoLoja { get; set; }   //CODIGO DA LOJA
        public DateTime data { get; set; } // TIMESTAMP CRIAÇÃO DO PEDIDO
        public string hora { get; set; } // HORÁRIO DA CRIAÇÃO DO PEDIDO
        public DateTime dataHora { get; set; } //DATA DO PEDIDO,
        public DateTime agendamentoDataInicio { get; set; } // DATA INICIAL DO PEDIDO
        public DateTime agendamentoHoraInicio { get; set; } // HORA INICIAL DO AGENDAMENTO DO PEDIDO
        public DateTime agendamentoDataFim { get; set; } // DATA FINAL DO AGENDAMENTO DO PEDIDO
        public DateTime agendamentoHoraFim { get; set; } // HORA FINAL DO AGENDAMENTO DE PEDIDO
        public bool entrega { get; set; } //  DELIVERY = TRUE OU TOGO = FALSE
        public bool cpfNaNota { get; set; } //  SIM  = TRUE OU NÃO = FALSE
        public string status { get; set; }//STATUS DO PEDIDO
        public string statusDescricao { get; set; }//DESCRIÇÃO DO STATUS DO PEDIDO
        public string pessoaAutorizadaRecebimento { get; set; } // PESSOA AUTORIZADA A RECEBER 
        public int quantidadeItemUnico { get; set; }// QUANTIDADE DE ITENS DO PEDIDO
        public decimal valorMercado { get; set; } // VALOR MERCADO
        public decimal valorConveniencia { get; set; } // VALOR CONVENIENCIA
        public decimal valorEntrega { get; set; } // VALOR DO PEDIDO PARA A ENTREGA
        public decimal valorRetirada { get; set; } // VALOR DO PEDIDO PARA A RETIRADA
        public decimal valorTroco { get; set; }// VALOR DE TROCO CASO SEJA ESCOLHIDO DINHEIRO
        public decimal valorDesconto { get; set; }// VALOR DE DESCONTO
        public decimal valorTotal { get; set; } // VALOR TOTAL DO PEDIDO
        public decimal valorCorrigido { get; set; }// VALOR CORRIGIDO

        public Pedido()
        {

        }

        public Pedido(int idLoja, int idCliente, string codigo, string codigoLoja, DateTime data, string hora, DateTime dataHora, DateTime agendamentoDataInicio, DateTime agendamentoHoraInicio, DateTime agendamentoDataFim, DateTime agendamentoHoraFim, bool entrega, bool cpfNaNota, string status, string statusDescricao, string pessoaAutorizadaRecebimento, int quantidadeItemUnico, decimal valorMercado, decimal valorConveniencia, decimal valorEntrega, decimal valorRetirada, decimal valorTroco, decimal valorDesconto, decimal valorTotal, decimal valorCorrigido)
        {
            this.idLoja = idLoja;
            this.idCliente = idCliente;
            this.codigo = codigo;
            this.codigoLoja = codigoLoja;
            this.data = data;
            this.hora = hora;
            this.dataHora = dataHora;
            this.agendamentoDataInicio = agendamentoDataInicio;
            this.agendamentoHoraInicio = agendamentoHoraInicio;
            this.agendamentoDataFim = agendamentoDataFim;
            this.agendamentoHoraFim = agendamentoHoraFim;
            this.entrega = entrega;
            this.cpfNaNota = cpfNaNota;
            this.status = status;
            this.statusDescricao = statusDescricao;
            this.pessoaAutorizadaRecebimento = pessoaAutorizadaRecebimento;
            this.quantidadeItemUnico = quantidadeItemUnico;
            this.valorMercado = valorMercado;
            this.valorConveniencia = valorConveniencia;
            this.valorEntrega = valorEntrega;
            this.valorRetirada = valorRetirada;
            this.valorTroco = valorTroco;
            this.valorDesconto = valorDesconto;
            this.valorTotal = valorTotal;
            this.valorCorrigido = valorCorrigido;
        }
    }

    public class Plataforma
    {        
        public string plataforma { get; set; }//PLATAFORMA EM QUE O PEDIDO É FEITO
        public Plataforma()
        {

        }

        public Plataforma(string plataforma)
        {
            this.plataforma = plataforma;
        }
    }

    public class EnderecoEntrega {

        public int id { get; set; } //ID DO PEDIDO
        public Endereco Endereco { get; set; }
        public decimal latitude { get; set; }// LATITUDE DO ENDEREÇO DO CLIENTE
        public decimal longitude { get; set; }// LONGITUDE DO ENDEREÇO DO CLIENTE

        public EnderecoEntrega()
        {

        }

        public EnderecoEntrega(int id, Endereco endereco, decimal latitude, decimal longitude)
        {
            this.id = id;
            Endereco = endereco;
            this.latitude = latitude;
            this.longitude = longitude;
        }
    }

    public class Endereco
    {
        public string logradouro { get; set; }//ENDERÇO DE ENTREGA DO PEDIDO
        public string numero { get; set; }// NUMERO DO ENDEREÇO PARA ENTREGA
        public string complemento { get; set; }// COMPLEMENTO DO ENDEREÇO
        public string bairro { get; set; }//BAIRRO
        public string cidade { get; set; }//CIDADE
        public string uf { get; set; }// ESTADO EM SIGLA
        public string estado { get; set; }// ESTADO EM NOME
        public string cep { get; set; }// CEP

        public Endereco()
        {

        }

        public Endereco(string logradouro, string numero, string complemento, string bairro, string cidade, string uf, string estado, string cep)
        {
            this.logradouro = logradouro;
            this.numero = numero;
            this.complemento = complemento;
            this.bairro = bairro;
            this.cidade = cidade;
            this.uf = uf;
            this.estado = estado;
            this.cep = cep;
        }
    }

    public class Loja
    {
        public int id { get; set; }
        public string nome { get; set; }// NOME DO ESTABELECIMENTO DO PARCEIRO
        public string cnpj { get; set; }// CNPJ DO PARCEIRO
        public bool status { get; set; } // STATUS DO PARCEIRO (ATIVO / INATIVO)
        public Endereco Endereco { get; set; } // ENDEREÇO DO PARCEIRO   

        public Loja()
        {

        }

        public Loja(int id, string nome, string cnpj, bool status, Endereco endereco)
        {
            this.id = id;
            this.nome = nome;
            this.cnpj = cnpj;
            this.status = status;
            Endereco = endereco;
        }
    }

    public class Rede
    {
        public int id { get; set; }// ID DA REDE DO MERCADO
        public string nome { get; set; }//NOME DA REDE

        public Rede()
        {

        }

        public Rede(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
        }
    }

    public class Cliente
    {
        public int id { get; set; }// ID DO CLIENTE NA BASE
        public string nome { get; set; } //NOME DO CLIENTE
        public string email { get; set; }// E-MAIL DO CLIENTE (AVALIAR O LGPD)
        public string cpf { get; set; }// CPF DO CLIENTE PARA EMISSÃO DO COMPROVANTE FISCAL
        public bool tipo { get; set; } // TIPO DE CLIENTE FISICA / JURIDICA
        public bool publicidadeEmail { get; set; }// TRUE = SIM OU FALSE = NÃO
        public bool publicidadeSms { get; set; } // TRUE = SIM OU FALSE = NÃO
        public string telefoneCelular { get; set; }// TELEFONE DO CLIENTE (AVALIAR O LGPD)
        public List<Endereco> Enderecos { get; set; }
        public Cliente()
        {
            Enderecos = new List<Endereco>();
        }

        public Cliente(int id, string nome, string email, string cpf, bool tipo, bool publicidadeEmail, bool publicidadeSms, string telefoneCelular)
        {
            this.id = id;
            this.nome = nome;
            this.email = email;
            this.cpf = cpf;
            this.tipo = tipo;
            this.publicidadeEmail = publicidadeEmail;
            this.publicidadeSms = publicidadeSms;
            this.telefoneCelular = telefoneCelular;

            Enderecos = new List<Endereco>();
        }
    }

    public class ItemPedido
    {
        public int id { get; set; }
        public int index { get; set; }// NÚMERO DO ITEM NA LISTA DE ITENS
        public string codigo { get; set; }//CÓDIGO DO ITEM
        public string codigoLoja { get; set; }// CÓDIGO DA LOJA
        public bool pesoVariavel { get; set; }// PESO VARIÁVEL (TRUE = SIM OU FALSE = NÃO)
        public string codigoBarra { get; set; }//NUMERO DO CODIGO DE BARRAS
        public string plu { get; set; }// CÓDIGO INTERNO DO PRODUTO
        public string produto { get; set; }// NOME DO PRODUTO
        public string observacao { get; set; }// OBSERVAÇÃO DO ITEM
        public decimal quantidade { get; set; }// QUANTIDADE DO PRODUTO
        public decimal quantidade3 { get; set; }// 
        public decimal valor { get; set; }// VALOR UNITÁRIO DO PRODUTO
        public decimal valorTotal { get; set; }// VALOR TOTAL DO ITEM (QTDE X PREÇO UNITÁRIO)
        public bool indisponivel { get; set; }// PRODUTO FOI MARCADO COMO INDISPONIVEL
        public bool desistencia { get; set; }// PRODUTO FOI MARCADO COMO DESISTÊNCA DO CLIENTE.
        public ItemPedido()
        {

        }

        public ItemPedido(int id, int index, string codigo, string codigoLoja, bool pesoVariavel, string codigoBarra, string plu, string produto, string observacao, decimal quantidade, decimal quantidade3, decimal valor, decimal valorTotal, bool indisponivel, bool desistencia)
        {
            this.id = id;
            this.index = index;
            this.codigo = codigo;
            this.codigoLoja = codigoLoja;
            this.pesoVariavel = pesoVariavel;
            this.codigoBarra = codigoBarra;
            this.plu = plu;
            this.produto = produto;
            this.observacao = observacao;
            this.quantidade = quantidade;
            this.quantidade3 = quantidade3;
            this.valor = valor;
            this.valorTotal = valorTotal;
            this.indisponivel = indisponivel;
            this.desistencia = desistencia;
        }
    }

    public class TransacaoPagamento
    {
        public string Transacao { get; set; }

        public TransacaoPagamento()
        {

        }

        public TransacaoPagamento(string transacao)
        {
            Transacao = transacao;
        }
    }

    public class Pagamento
    {
        public int id { get; set; }// ID DO PAGAMENTO
        public string nome { get; set; }// NOME DA FORMA DE PAGAMENTO
        public decimal valor { get; set; }// VALOR PAGO NO PEDIDO
        public string tipo { get; set; }// TIPO DE PAGAMENTO
        public List<TransacaoPagamento> transacoes { get; set; }

        public Pagamento()
        {
            transacoes = new List<TransacaoPagamento>();
        }

        public Pagamento(int id, string nome, decimal valor, string tipo)
        {
            this.id = id;
            this.nome = nome;
            this.valor = valor;
            this.tipo = tipo;
            transacoes = new List<TransacaoPagamento>();
        }
    }
}
