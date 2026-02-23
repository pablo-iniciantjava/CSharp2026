using System; // Importa funcionalidades básicas (Console, Math, etc.)
using System.Globalization; // Permite usar configurações de cultura (formatação decimal)

class Retangulo // Declara a classe chamada Retangulo
{
    static void Main() // Método principal (ponto de entrada do programa)
    {
        var ci = CultureInfo.InvariantCulture; 
        // Define cultura invariável (usa ponto como separador decimal)

        Console.Write("Digite a base do retângulo: "); 
        // Mostra mensagem pedindo a base

        double b = double.Parse(Console.ReadLine(), ci); 
        // Lê o valor digitado e converte para double usando a cultura definida

        Console.Write("Digite a altura do retângulo: "); 
        // Mostra mensagem pedindo a altura

        double h = double.Parse(Console.ReadLine(), ci); 
        // Lê o valor digitado e converte para double

        double area = b * h; 
        // Calcula a área (base × altura)

        double perimetro = 2 * (b + h); 
        // Calcula o perímetro (2 × (base + altura))

        double diagonal = Math.Sqrt(b * b + h * h); 
        // Calcula a diagonal usando a raiz quadrada (Teorema de Pitágoras)

        Console.WriteLine($"Area = {area.ToString("F2", ci)}"); 
        // Exibe a área com 2 casas decimais

        Console.WriteLine($"Perimetro = {perimetro.ToString("F2", ci)}"); 
        // Exibe o perímetro com 2 casas decimais

        Console.WriteLine($"Diagonal = {diagonal.ToString("F4", ci)}"); 
        // Exibe a diagonal com 4 casas decimais
    }
}