using System; // Biblioteca padrão
using System.Collections.Generic; // Lista
using System.Text; // Texto

namespace Imposto.Classe.Entidades // Namespace
{
    internal class Pj : ContriBuintes // Herança
    {
        // Campo privado
        private int numeroFuncionarios;

        // Propriedade
        public int NumeroFuncionarios
        {
            get { return numeroFuncionarios; } // Retorna valor
            set { numeroFuncionarios = value; } // Define valor
        }

        // Construtor
        public Pj(string nome, double rendaAnual, int numeroFuncionarios)
            : base(nome, rendaAnual) // Classe base
        {
            NumeroFuncionarios = numeroFuncionarios; // Inicializa
        }

        // Método sobrescrito
        public override double CalcularImposto()
        {
            if (NumeroFuncionarios > 10) // Regra
            {
                return RendaAnual * 0.14; // 14%
            }
            else
            {
                return RendaAnual * 0.16; // 16%
            }
        }
    }
}