using static System.Console;

//---------------------------------------------DECLARAÇÃO DE VARIÁVEIS---------------------------------------------

int codigo, quantidade;

//---------------------------------------------ENTRADA DE DADOS---------------------------------------------
switch (codigo)
{
    case 1:
        WriteLine($"O valor total do produtoZ: ");
        quantidade = int.Parse(ReadLine());
        WriteLine($"Valor total: R$ {quantidade * 10}");
        break;
    case 2:
        WriteLine("Digite a quantidade de X-Salada: ");
        quantidade = int.Parse(ReadLine());
        WriteLine($"Valor total: R$ {quantidade * 15}");
        break;
    case 3:
        WriteLine("Digite a quantidade de X-Bacon: ");
        quantidade = int.Parse(ReadLine());
        WriteLine($"Valor total: R$ {quantidade * 18}");
        break;
    case 4:
        WriteLine("Digite a quantidade de Torrada Simples: ");
        quantidade = int.Parse(ReadLine());
        WriteLine($"Valor total: R$ {quantidade * 8}");
        break;
    case 5:
        WriteLine("Digite a quantidade de Refrigerante: ");
        quantidade = int.Parse(ReadLine());
        WriteLine($"Valor total: R$ {quantidade * 13}");
        break;
    default:
        WriteLine("Código inválido");
        break;
}