using agilium.integracao.ifoodmercado.dominio.Enums;
using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public abstract class Entidade : Notifiable
    {
     

        public Entidade()
        {
            Id = GerarId();
            DataCadastro = DateTime.Now;
            Ativar();
            Atualizar();
        }

        private Int64 GerarId()
        {
            Guid guid = Guid.NewGuid();

            byte[] _bytes = guid.ToByteArray();
            return BitConverter.ToInt64(_bytes, 0);
        }

        public Int64 Id { get; private set; }
        public string Codigo { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public DateTime DataUltimaAtualizacao { get; private set; }
        public EAtivo Ativo { get; private set; }


        public void Atualizar()
        {
            DataUltimaAtualizacao = DateTime.Now;
        }

        public void AtualizarCodigo(string codigo)
        {
            Codigo = codigo;
        }

        public void Ativar()
        {
            Ativo = EAtivo.Ativo;
            Atualizar();
        }

        public void Inativar()
        {
            Ativo = EAtivo.Inativo;
            Atualizar();
        }
    }
}
