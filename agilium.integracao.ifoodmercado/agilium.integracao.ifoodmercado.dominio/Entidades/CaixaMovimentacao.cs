using System;
using System.Collections.Generic;
using System.Security.Authentication.ExtendedProtection;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class CaixaMovimentacao: Entidade
    {
        public Int64? IDCAIXA { get; private set; }
        public virtual Caixa Caixa { get; private set; }
        public int? TPMOV { get; private set; }
        public string DSMOV { get; private set; }
        public double? VLMOV { get; private set; }
        public int? STMOV { get; private set; }
        private CaixaMovimentacao()
        {

        }
         
    }
}
