using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class Fornecedor: Entidade
    {
        public Int64 IDENDERECO { get; private set; }
        public virtual Endereco Endereco { get; private set; }
        public string CDFORN { get; private set; }
        public string NMRZSOCIAL { get; private set; }
        public string NMFANTASIA { get; private set; }
        public string TPPESSOA { get; private set; }
        public string NUCPFCNPJ { get; private set; }
        public string DSINSCR { get; private set; }
        public int TPFISCAL { get; private set; }
        public int STFORNEC { get; private set; }

        public virtual IReadOnlyCollection<FornecedorProduto> ForncedorProduto { get { return _fornecProduto.ToList(); } }
        private IList<FornecedorProduto> _fornecProduto { get; set; }
        public virtual IReadOnlyCollection<FornecedorContato> FornecedorContato { get { return _fornecedorContato.ToList(); } }
        private IList<FornecedorContato> _fornecedorContato { get; set; }
        public virtual IReadOnlyCollection<PedidoItem> PedidoItem { get { return _pedidoItem.ToList(); } }
        private IList<PedidoItem> _pedidoItem { get; set; }
        public virtual IReadOnlyCollection<ContaPagar> ContaPagar { get { return _contaPagar.ToList(); } }
        private IList<ContaPagar> _contaPagar { get; set; }
        public virtual IReadOnlyCollection<Compra> Compra { get { return _compra.ToList(); } }
        private IList<Compra> _compra { get; set; }

        private Fornecedor()
        {
            _fornecProduto = new List<FornecedorProduto>();
            _fornecedorContato = new List<FornecedorContato>();
            _pedidoItem = new List<PedidoItem>();
            _contaPagar = new List<ContaPagar>();
            _contaPagar = new List<ContaPagar>();
        }
    
    }
}
