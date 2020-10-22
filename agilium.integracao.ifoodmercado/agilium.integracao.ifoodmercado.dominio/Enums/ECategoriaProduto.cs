using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Enums
{
    public enum ECategoriaProduto
    {
        [Display(Name = "Simples")]
        S,
        [Display(Name = "Composto")]
        C,
        [Display(Name = "Combo")]
        B
    }
}
