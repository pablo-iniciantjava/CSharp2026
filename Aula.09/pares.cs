using static System.Console;    

//---------------------------------------------DECLARAÇÃO DE VARIÁVEIS---------------------------------------------
int numero, valor;
try
{
   Write("Quantos números voce vai digitar ?: ");
   numero = int.Parse(ReadLine());


//                                             Processamento de dados-----------------------------------------------
for (int i = 0; i < numero; i++)
//Testes de 
    {   
        Write($"Digite um número: ");
        valor = int.Parse(ReadLine());
        if (valor < 0)
        {
            Write ("Negativo");
        }
        else if (valor > 0)
        {
            Write("Positivo");
        }
        else
        {
            Write("Nulo");
        }

    
    if ((valor % 2 )== 0)
    {
        WriteLine("PAR");
    }
    else if ((valor % 2) != 0)
    {
        WriteLine("IMPAR");
    }
        
    {
    Write($"Digite o {i + 1}º número: ");
    valor = int.Parse(ReadLine());
    if (valor % 2 == 0)
    {
        WriteLine($"O número {valor} é par");
    }
    else
    {
        WriteLine($"O número {valor} é impar");
    }
}

    }
}
catch (Exception ex)
{
    WriteLine($"Digite valores válido,  erro: {ex.Message}");
}