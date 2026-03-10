using static System.Console;
//---------------------------------------------DECLARAÇÃO DE VARIÁVEIS---------------------------------------------
int x;
while (true)
{
    Write("Digite um número ou zero para sair: ");
    x = int.Parse(ReadLine());
    int x, resultado;
    if (x == 0)
    {
        WriteLine("Programa encerrado.");
        break; // Encerra o loop se o número for zero
    }
    if ((x % 2) == 0)
    {
        //Numero par
        //Processamento de dados
        resultado = x + (x+2) + (x+4) + (x+6) + (x+8);
    }
else
{ 
    //Numero impar
    x = x + 1;
    resultado = x + (x+2) + (x+4) + (x+6) + (x+8);
}

    WriteLine($"Soma = {resultado}");
    
    }
