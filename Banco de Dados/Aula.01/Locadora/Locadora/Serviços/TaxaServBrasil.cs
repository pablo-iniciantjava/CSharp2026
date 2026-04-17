namespace Projeto.Servicos
{
    class TaxaSrvBrasil
    {
        public double Calcular(double valor)
        {
            if (valor <= 100.0)
            {
                return valor * 0.20;
            }
            else
            {
                return valor * 0.15;
            }
        }
    }
}