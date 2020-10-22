using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace agilium.integracao.ifoodmercado.dominio.Entidades
{
    public class Usuario: Entidade
    {
        public string nome { get; private set; }
        public string cpf { get; private set; }
        public string ender { get; private set; }
        public int? num { get; private set; }
        public string compl { get; private set; }
        public string bairro { get; private set; }
        public string cep { get; private set; }
        public string cidade { get; private set; }
        public string uf { get; private set; }
        public string tel1 { get; private set; }
        public string cel { get; private set; }
        public DateTime? dtnasc { get; private set; }
        public string usuario { get; private set; }
        public string senha { get; private set; }
        public string email { get; private set; }
        public string foto { get; private set; }
        public string tel2 { get; private set; }
        public string ativo { get; private set; }
        public DateTime? dtcad { get; private set; }
        public int? id_perfil { get; private set; }

        public virtual IReadOnlyCollection<CaixaMoeda> CaixaMoedas { get { return _caixaMoeda.ToList(); } }
        private IList<CaixaMoeda> _caixaMoeda { get; set; }
        public virtual IReadOnlyCollection<Turno> TurnoInicial { get { return _turnoInicial.ToList(); } }
        private IList<Turno> _turnoInicial { get; set; }
        public virtual IReadOnlyCollection<Turno> TurnoFinal { get { return _turnoFinal.ToList(); } }
        private IList<Turno> _turnoFinal { get; set; }
        public virtual IReadOnlyCollection<VendaCancelada> VendaCancelada { get { return _vendaCancelada.ToList(); } }
        private IList<VendaCancelada> _vendaCancelada { get; set; }
        public virtual IReadOnlyCollection<EmpresaAutorizacao> EmpresaAutorizacao { get { return _empresaAut.ToList(); } }
        private IList<EmpresaAutorizacao> _empresaAut { get; set; }
        public virtual IReadOnlyCollection<Funcionario> Funcionarios { get { return _funcionarios.ToList(); } }
        private IList<Funcionario> _funcionarios { get; set; }
        public virtual IReadOnlyCollection<Perda> Perdas { get { return _perda.ToList(); } }
        private IList<Perda> _perda { get; set; }
        public virtual IReadOnlyCollection<InventarioItem> InventarioItem { get { return _inventarioItem.ToList(); } }
        private IList<InventarioItem> _inventarioItem { get; set; }
        public virtual IReadOnlyCollection<ContaReceber> ContaReceber { get { return _contaReceber.ToList(); } }
        private IList<ContaReceber> _contaReceber { get; set; }
        public virtual IReadOnlyCollection<ContaPagar> ContaPagar { get { return _contaPagar.ToList(); } }
        private IList<ContaPagar> _contaPagar { get; set; }
        private Usuario()
        {
            _caixaMoeda = new List<CaixaMoeda>();
            _turnoInicial = new List<Turno>();
            _turnoFinal = new List<Turno>();
            _vendaCancelada = new List<VendaCancelada>();
            _empresaAut = new List<EmpresaAutorizacao>();
            _funcionarios = new List<Funcionario>();
            _perda = new List<Perda>();
            _inventarioItem = new List<InventarioItem>();
            _contaReceber = new List<ContaReceber>();
            _contaPagar = new List<ContaPagar>();
        }
        
    }
}
