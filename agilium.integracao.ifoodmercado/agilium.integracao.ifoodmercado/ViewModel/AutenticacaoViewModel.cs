using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.ViewModel
{
    public class AutenticacaoViewModel
    {
        public string Client_Id { get; set; }
        public string Client_Secret { get; set; }

        public AutenticacaoViewModel(string client_Id, string client_Secret)
        {
            Client_Id = client_Id;
            Client_Secret = client_Secret;
        }
    }
}
