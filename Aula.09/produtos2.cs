using System.Linq.Expressions;
using static System.Console;

static void Total (int qtd, double valor)

{
    WriteLine($"O valor total é de R${qtd * valor}");
}

//---------------------------------------------DECLARAÇÃO DE VARIÁVEIS---------------------------------------------

int codigo, quantidade10;

//---------------------------------------------ENTRADA DE DADOS---------------------------------------------
try
{
Write("Digite o código do produto: ");
codigo = int.Parse(ReadLine());
Write($"Digite a quantidade de produto:");
quantidade = int.Parse(ReadLine()); 


switch (codigo)
{
    case 1:
        Total(quantidade, 5.00);
    //  WriteLine($"Valor total: R$ {quantidade * 10}");
        break;
    case 2:
        Total(quantidade, 4.50);
    //   WriteLine($"Valor total: R$ {quantidade * 15}");
        break;

    case 3:
        Total(quantidade, 3.75);
    // WriteLine($"Valor total: R$ {quantidade * 3.75}");
        break;
    case 4:
        Total(quantidade, 8.99);
    // WriteLine($"Valor total: R$ {quantidade * 8.99}");

        break;
    case 5:
        Total(quantidade, 11.33);
    // WriteLine($"Valor total: R$ {quantidade * 11.33}");
        break;
    default:
        WriteLine("Código do produto não cadastrado");
    break; 

    }     
}
catch (Exception ex)
{
    WriteLine($"Digite valores válido,  erro: {ex.Message}");
}
















































