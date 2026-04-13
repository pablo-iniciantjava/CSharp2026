using System; // Biblioteca padrão
using System.Collections.Generic; // Lista
using System.Text; // Texto

namespace Imposto.Classe.Entidades // Namespace
{
    internal class Pf : ContriBuintes // Herança
    {
        // Campo privado
        private double gastosSaude;

        // Propriedade
        public double GastosSaude
        {
            get { return gastosSaude; } // Retorna valor
            set { gastosSaude = value; } // Define valor
        }

        // Construtor
        public Pf(string nome, double rendaAnual, double gastosSaude)
            : base(nome, rendaAnual) // Chama classe base
        {
            GastosSaude = gastosSaude; // Inicializa
        }

        // Método sobrescrito
        public override double CalcularImposto()
        {
            double imposto; // Variável

            if (RendaAnual < 20000.0) // Regra
            {
                imposto = RendaAnual * 0.15; // 15%
            }
            else
            {
                imposto = RendaAnual * 0.25; // 25%
            }

            imposto -= GastosSaude * 0.5; // Desconto saúde

            return imposto; // Retorna resultado
        }
    }
}