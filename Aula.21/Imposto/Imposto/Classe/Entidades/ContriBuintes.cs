using System; // Biblioteca padrão
using System.Collections.Generic; // Lista
using System.Text; // Texto
using Imposto.Classe.Contratos; // Importa interface

namespace Imposto.Classe.Entidades // Namespace
{
    internal abstract class ContriBuintes : InterFace // Classe abstrata + interface
    {
        // Campo privado
        private string nome;

        // Campo privado
        private double rendaAnual;

        // Propriedade protegida
        protected string Nome
        {
            get { return nome; } // Retorna nome
            set { nome = value; } // Define nome
        }

        // Propriedade protegida
        protected double RendaAnual
        {
            get { return rendaAnual; } // Retorna renda
            set { rendaAnual = value; } // Define renda
        }

        // Construtor
        public ContriBuintes(string nome, double rendaAnual)
        {
            Nome = nome; // Inicializa nome
            RendaAnual = rendaAnual; // Inicializa renda
        }

        // Método abstrato
        public abstract double CalcularImposto(); // Implementação nas filhas
    }
}