using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class TurnoPreco: Entidade
    {
        public Int64? IDPRODUTO { get; private set; }
        public virtual Produto Produto { get; private set; }
        public int? NUTURNO { get; private set; }
        public int? TPDIFERENCA { get; private set; }
        public int? TPVALOR { get; private set; }
        public double? NUVALOR { get; private set; }
        public string NMUSUARIO { get; private set; }
        public DateTime? DTHRCAD { get; private set; }
        private TurnoPreco()
        {

        }
    }
}
