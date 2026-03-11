//Exercicio  de lista com a estrutura de repetição for//

using static System.Console;

//Declaração de Variavel

int n;

List<double> numeros = new List<double>();

//Dados de entrada 


WriteLine("Quantos numeros voce deseja digitar? ");
n = int.Parse(ReadLine());

for (int i = 0; i < n; i++)
{
    Write("Digite um numero: ");
    numeros.Add(double.Parse(ReadLine()));
}

Write("Valores = ");

for (int i = 0; i <n ; i++)
{
    Write($"{numeros[i]} ");
}

Write($"\nSoma = {numeros.Sum()}");
Write($"\nMedia = {numeros.Average()}");









