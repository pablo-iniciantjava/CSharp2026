

using System;

namespace DepartamentoPessoal.Classes.Entidade
{
    internal class Terceiro : Funcionario
    {
        // Campo
        private double despesa;

        // Propriedade
        public double DespesaAdicional
        {
            get { return despesa; }
            set { despesa = value; }
        }

        // Construtor
        public Terceiro(string nomeColaborador, int jornadaTrabalho, double valorHora, double despesaAdicional)
            : base(nomeColaborador, jornadaTrabalho, valorHora)
        {
            DespesaAdicional = despesaAdicional;
        }

        // Método sobrescrito
        public override double Pagamento()
        {
            // Regra comum: terceirizado recebe +110% da despesa
            return base.Pagamento() + (DespesaAdicional * 0.2);
        }
    }
}
