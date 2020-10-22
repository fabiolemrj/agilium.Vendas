using System;
using System.Collections.Generic;
using System.Security.Authentication.ExtendedProtection;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class CaixaMoeda: Entidade
    {
        public Int64? IDCAIXA { get; private set; }
        public virtual Caixa Caixa { get; private set; }
        public Int64? IDMOEDA { get; private set; }
        public virtual Moeda Moeda { get; private set; }
        public double? VLMOEDAORIGINAL { get; private set; }
        public double? VLMOEDACORRECAO { get; private set; }
        public Int64? IDUSUARIOCORRECAO { get; private set; }
        public virtual Usuario UsuarioCorrecao { get; private set; }
        public DateTime? DTHRCORRECAO { get; private set; }

        private CaixaMoeda()
        {

        }
    }
}
