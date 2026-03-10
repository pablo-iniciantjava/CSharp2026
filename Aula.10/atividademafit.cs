using static System.Console;
using System;

WriteLine("Aplicativo de controle de fluxo de carros - Parque Nacional dos Lençóis Maranhenses");
WriteLine("Bem-vindo ao sistema de controle de fluxo de turistas!");

int totalTuristas = 0;
int totalVeiculos = 0;

while (true)
{
    Write("Digite a placa do carro (entrada/saida) ou 'sair' para encerrar: ");
    string movimento = ReadLine().ToLower();

    if (movimento == "sair")
        break;

    if (movimento != "entrada" && movimento != "saida")
    {
        WriteLine("Erro: Por favor, digite \"entrada\" ou \"saida\".");
        continue;
    }

    Write("Digite o número de turistas: ");
    int turistas;
    while (!int.TryParse(ReadLine(), out turistas) || turistas < 0 || turistas > 4)
    {
        WriteLine("Erro: digite um número válido de turistas (0 a 4).");
        Write("Digite o número de turistas: ");
    }

    DateTime registro = DateTime.Now;

    if (movimento == "entrada")
    {
        totalVeiculos++;
        totalTuristas += turistas;
        WriteLine($"Família registrada em {registro}");
        WriteLine($"Número de {turistas} turistas registrados.");
    }
    else // saida
    {
        // impede valores negativos
        if (totalVeiculos > 0 && totalTuristas >= turistas)
        {
            totalVeiculos--;
            totalTuristas -= turistas;
            WriteLine($"Família registrada em {registro}");
            WriteLine($"Número de {turistas} turistas registrados.");
        }
        else
        {
            WriteLine("Erro: não há veículos suficientes no parque para registrar a saída.");
        }
    }

    WriteLine($"Total de turistas no parque: {totalTuristas}");
    WriteLine();
}

// Mensagem final
WriteLine("Encerrando o aplicativo.");
WriteLine($"Veículos ainda no parque: {totalVeiculos}");
WriteLine($"Turistas ainda no parque: {totalTuristas}");