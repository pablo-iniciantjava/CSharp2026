

using Figuras.Classes.Enumeracoes;

namespace Figuras.Classes.Entidades
{
    abstract internal class Forma : IArea
    {
        private Cor cor;
        protected Cor CorDaForma { get; set; }

        // Construtor que aceita a cor — resolve chamadas como new Forma(Cor.Vermelho)
        public Forma(Cor cor)
        {
            this.cor = cor;
            this.CorDaForma = cor;
        }

        // Implementação padrão; subclasses podem sobrescrever
        public virtual double Area()
        {
            return 0.0;
        }
    }

    internal class Circulo : Forma, IArea
    {
        private double raio;
        public double Raio
        {
            get => raio;
            set => raio = value;
        }

        // Construtor com (Cor, double) — corresponde à chamada new Circulo(Cor.Rosa, 5)
        public Circulo(Cor cor, double raio) : base(cor)
        {
            Raio = raio;
        }

        // Área do círculo
        public override double Area()
        {
            return Math.PI * Raio * Raio;
        }
    }
}