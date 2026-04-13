using System; // Biblioteca padrão
using System.Collections.Generic; // Lista
using Imposto.Classe.Entidades; // Importa suas entidades
using static System.Console; // Facilita uso do Console

// Lista de contribuintes (polimorfismo)
List<ContriBuintes> lista = new List<ContriBuintes>();

// Pergunta quantidade
Write("Digite a quantidade de contribuintes: ");
int n = int.Parse(ReadLine()); // Lê valor

// Loop para cadastrar
for (int i = 0; i < n; i++)
{
    WriteLine($"Dados do contribuinte #{i + 1}:");

    Write("Pessoa física ou jurídica (f/j)? ");
    char tipo = char.Parse(ReadLine().ToLower()); // Tipo

    Write("Nome: ");
    string nome = ReadLine(); // Nome

    Write("Renda anual: ");
    double renda = double.Parse(ReadLine()); // Renda

    if (tipo == 'f') // Pessoa física
    {
        Write("Gastos com saúde: ");
        double saude = double.Parse(ReadLine()); // Saúde

        // Adiciona na lista (polimorfismo)
        lista.Add(new Pf(nome, renda, saude));
    }
    else // Pessoa jurídica
    {
        Write("Número de funcionários: ");
        int funcionarios = int.Parse(ReadLine()); // Funcionários

        // Adiciona na lista
        lista.Add(new Pj(nome, renda, funcionarios));
    }
}

// Variável para total
double total = 0.0;

// Impressão dos impostos
WriteLine("\nIMPOSTOS PAGOS:");

foreach (ContriBuintes c in lista) // Percorre lista
{
    double imposto = c.CalcularImposto(); // Polimorfismo

    WriteLine($"{c.GetType().Name} - R$ {imposto:F2}"); // Exibe

    total += imposto; // Soma total
}

// Exibe total arrecadado
WriteLine($"\nTOTAL DE IMPOSTO: R$ {total:F2}");

ReadLine(); // 