using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class CaPerfil: Entidade
    {
        public int id_perfil { get; private set; }
        public string descricao { get; private set; }
        public virtual IReadOnlyCollection<CaPermissao> CaPermissao { get { return _caPermissao.ToList(); } }
        private IList<CaPermissao> _caPermissao { get; set; }
        private CaPerfil()
        {
            _caPermissao = new List<CaPermissao>();
        }
    }
}
