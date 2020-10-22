using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class CaPermissao: Entidade
    {
        public int id_perfil { get; private set; }
        public virtual CaPerfil CaPerfil { get; private set; }
        public int id_area { get; private set; }
        public virtual CaArea CaArea { get; private set; }
        private CaPermissao()
        {

        }
    }
}
