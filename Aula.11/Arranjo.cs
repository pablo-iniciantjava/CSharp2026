using static System.Console;
using static System.Linq.Enumerable;
//Declaração de Variavel//
int n;

//Entrada de Dados//
WriteLine("Quantos numeros deseja digitar? ");
n = int.Parse(ReadLine());
if (n < 0)
  
{
    WriteLine("Valor inválido. O número deve ser positivo");
}

else if (n > 10)
{
    WriteLine("Máximo de valores para digitar igual a 10");
    WriteLine("Tente novamente!");
}
else
{
//Declaração do Vetor//
    int[] numeros = new int[n];
    for (int i = 0; i < numeros.Length; i++)
    {
        WriteLine($"Digite o {i + 1}º número: ");
        numeros[i] = int.Parse(ReadLine());
    }

    WriteLine("Números negativos");
    foreach (int item in Range (0, numeros.Length))
    {
     if (numeros [item]< 0)
        {
            WriteLine(numeros[item]);
        }   
    }
}