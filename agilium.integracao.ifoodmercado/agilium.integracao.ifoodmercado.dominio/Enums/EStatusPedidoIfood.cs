using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Enums
{
    public enum EStatusPedidoIfood
    {
        [Display(Name = "Cancelado")]
        CAN,
        [Display(Name = "Devolvido")]
        DEV,
        [Display(Name = "Realizado")]
        EMI,
        [Display(Name = "Recebido")]
        FIN,
        [Display(Name = "AguardandoRetiradaComItensIndisponiveis")]
        REP,
        [Display(Name = "AguardandoRetirada")]
        RET,
        [Display(Name = "AguardandoEntregaComItensIndisponiveis")]
        ENP,
        [Display(Name = "AguardandoEntrega")]
        ENT,
        [Display(Name = "EmSeparacao")]
        SEP,
        [Display(Name = "AguardandoPagamento")]
        APA,
        [Display(Name = "AguardandoExportacao-PDV")]
        PE0,
        [Display(Name = "MarcadComoExportado-PDV")]
        PE1
        
    }
}
