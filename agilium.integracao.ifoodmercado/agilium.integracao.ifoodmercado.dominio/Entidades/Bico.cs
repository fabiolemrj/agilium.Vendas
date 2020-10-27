using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class Bico: Entidade
    {
        public Int64? IDBOMBA { get; private set; }
        public virtual Bomba Bomba { get; private set; }
        public string CDBICO { get; private set; }
        public Int64? IDESTOQUE { get; private set; }
        public virtual Estoque Estoque { get; private set; }
        public int? STBICO { get; private set; }
        private Bico()
        {

        }

        public Bico(Bomba bomba, string cDBICO, Estoque estoque, int? sTBICO)
        {
            AddNotifications(bomba,estoque);

            AddNotifications(new Contract()
                .Requires()
                .HasMaxLen(cDBICO, 6,"CDBICO", "o campo codigo tem mais de 6 caracteres")
                .HasMinLen(cDBICO, 3,"CDBICO","o campo codigo deve ter pelo menos 3 caracterers")
                .IsNullOrNullable(sTBICO,"STBICO","A situãção do bico não pode ser nula")
            );
            Bomba = bomba;
            CDBICO = cDBICO;
            Estoque = estoque;
            STBICO = sTBICO;
        }
    }
}
