using static System.Console;

//-----------Exercício Lanchonete (URI 1038)-----------------

// Dicionário com código do produto e preço
Dictionary<int, double> produtos = new Dictionary<int, double>()
{
    {1, 4.00},   // Cachorro Quente
    {2, 4.50},   // X-Salada
    {3, 5.00},   // X-Bacon
    {4, 2.00},   // Torrada simples
    {5, 1.50}    // Refrigerante
};

// Leitura do código do produto
Write("Código do produto: ");
int codigo = int.Parse(ReadLine());

// Leitura da quantidade
Write("Quantidade: ");
int quantidade = int.Parse(ReadLine());

// Cálculo do total
double total = produtos[codigo] * quantidade;

// Saída sem formatação F2
WriteLine($"Total: R$ {total}");