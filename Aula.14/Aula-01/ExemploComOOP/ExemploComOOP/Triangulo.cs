
namespace ExemploComOOP
{
    internal class Triangulo
    {
        // Campos ou Atributos
        public double ladoA;
        public double ladoB;
        public double ladoC;

        //Metodo

        public double Area()
        {

            double p = (ladoB + ladoB + ladoC) / 2;
            double area = Math.Sqrt(p * (p + ladoA) * ladoB) * (p - ladoC);
            return area;
        }
    }
}
