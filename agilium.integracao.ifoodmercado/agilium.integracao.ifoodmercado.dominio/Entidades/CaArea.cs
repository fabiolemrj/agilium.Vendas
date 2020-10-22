using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class CaArea: Entidade
    {
        public int id_area { get; private set; }
        public int? hierarquia { get; private set; }
        public int? ordem { get; private set; }
        public string titulo { get; private set; }
        public int? subitem { get; private set; }
        public int? idtag { get; private set; }
        public virtual IReadOnlyCollection<CaPermissao> CaPermissao { get { return _caPermissao.ToList(); } }
        private IList<CaPermissao> _caPermissao { get; set; }
        private CaArea()
        {
            _caPermissao = new List<CaPermissao>();
        }
    }
}
