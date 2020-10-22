using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class CompraItem: Entidade
    {
        public Int64? IDCOMPRA { get; private set; }
        public virtual Compra Compra { get; private set; }
        public Int64? IDPRODUTO { get; private set; }
        public virtual Produto Produto { get; private set; }
        public Int64? IDESTOQUE { get; private set; }
        public virtual Estoque Estoque { get; private set; }
        public string DSPRODUTO { get; private set; }
        public string CDEAN { get; private set; }
        public string CDNCM { get; private set; }
        public string CDCEST { get; private set; }
        public string SGUN { get; private set; }
        public double? NUQTD { get; private set; }
        public double? NURELACAO { get; private set; }
        public double? VLUNIT { get; private set; }
        public double? VLTOTAL { get; private set; }
        public DateTime? DTVALIDADE { get; private set; }
        public int? NUCFOP { get; private set; }
        public double? VLOUTROS { get; private set; }
        public double? VLBSRET { get; private set; }
        public double? PCICMSRET { get; private set; }
        public double? PCREDUCAO { get; private set; }
        public string CDCSTICMS { get; private set; }
        public string CDCSTPIS { get; private set; }
        public string CDCSTCOFINS { get; private set; }
        public string CDCSTIPI { get; private set; }
        public double? VLALIQPIS { get; private set; }
        public double? VLALIQCOFINS { get; private set; }
        public double? VLALIQICMS { get; private set; }
        public double? VLALIQIPI { get; private set; }
        public double? VLBSCALCPIS { get; private set; }
        public double? VLBSCALCCOFINS { get; private set; }
        public double? VLBSCALCICMS { get; private set; }
        public double? VLBSCALCIPI { get; private set; }
        public double? VLICMS { get; private set; }
        public double? VLPIS { get; private set; }
        public double? VLCOFINS { get; private set; }
        public double? VLIPI { get; private set; }
        public string CDPRODFORN { get; private set; }
        public double? VLNOVOPRECOVENDA { get; private set; }
        private CompraItem()
        {

        }
    }
}
