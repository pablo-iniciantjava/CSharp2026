using static System.Console; // Permite usar WriteLine e ReadLine sem precisar escrever Console.WriteLine/ReadLine

//-----------Exercício Lanchonete (URI 1038)-----------------

// Dicionário com código do produto e preço
Dictionary<int, double> produtos = new Dictionary<int, double>() 
{
    {1, 5.00},   // Código 1 = Cachorro Quente, preço 5.00
    {2, 3.50},   // Código 2 = X-Salada, preço 3.50
    {3, 4.80},   // Código 3 = X-Bacon, preço 4.80
    {4, 8.90},   // Código 4 = Torrada simples, preço 8.90
    {5, 7.32}    // Código 5 = Refrigerante, preço 7.32
};

try
{
    // Leitura do código do produto
    Write("Código do produto: "); // Mostra a mensagem pedindo o código
    int codigo = int.Parse(ReadLine()); // Lê o que o usuário digitou e converte para número inteiro

    // Leitura da quantidade
    Write("Quantidade: "); // Mostra a mensagem pedindo a quantidade
    int quantidade = int.Parse(ReadLine()); // Lê o que o usuário digitou e converte para número inteiro

    // Cálculo do total
    double total = produtos[codigo] * quantidade; // Multiplica o preço do produto (do dicionário) pela quantidade

    // Saída
    WriteLine($"Total: R$ {total}"); // Mostra o total a ser pago
}
catch (FormatException) // Captura erro quando o usuário digita algo que não é número
{
    WriteLine("Erro: você deve digitar apenas números."); // Mensagem de erro amigável
}
catch (KeyNotFoundException) // Captura erro quando o código do produto não existe no dicionário
{
    WriteLine("Erro: código de produto inválido."); // Mensagem de erro para código inexistente
}
catch (Exception ex) // Captura qualquer outro erro inesperado
{
    WriteLine($"Erro inesperado: {ex.Message}"); // Mostra a mensagem do erro
}