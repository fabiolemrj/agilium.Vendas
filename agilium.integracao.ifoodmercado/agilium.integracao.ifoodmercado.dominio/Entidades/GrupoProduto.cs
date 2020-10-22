using agilium.integracao.ifoodmercado.dominio.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class GrupoProduto: Entidade
    {
        public virtual EmpresaMysql Empresa { get; private set; }
        public Int64 idEmpresa { get; private set; }
        public string Nome { get; private set; }

        private GrupoProduto()
        {
        }

        public GrupoProduto(EmpresaMysql empresa,  string nome)
        {
            Empresa = empresa;
            Nome = nome;

            AddNotifications(empresa);

            AddNotifications(new Flunt.Validations.Contract()
               .Requires()
               .HasMaxLen(nome, 50, "Nome", "O campo Nome deve conter ate 50 caracteres")
               .HasMinLen(nome, 3, "Nome", "O campo Nome deve conter pelo menos 3 caracteres"));

        }


        //        IDGRUPO bigint PK
        //IDEMPRESA bigint
        //CDGRUPO varchar(6)
        //NMGRUPO varchar(50)
        //STATIVO int
    }
}
