using static System.Console;               // Usa membros estáticos de System.Console (Write, ReadLine, etc.) sem precisar prefixar com Console.

Write("Digite a ordem da matriz (max 10): "); // Exibe texto pedindo o tamanho da matriz.
int N = int.Parse(ReadLine());             // Lê a linha digitada, converte para int e guarda em N.

int[,] matriz = new int[N, N];             // Cria matriz bidimensional de inteiros com N linhas e N colunas.

// Entrada de dados
for (int i = 0; i < N; i++)                // Laço para cada linha da matriz.
{
    for (int j = 0; j < N; j++)            // Laço para cada coluna da linha atual.
    {
        Write($"Digite o valor para [{i},{j}]: "); // Pede o valor para a posição atual.
        matriz[i, j] = int.Parse(ReadLine());      // Lê o valor e armazena na matriz.
    }
}

// Mostrar diagonal principal
WriteLine("Diagonal principal:");           // Exibe título da diagonal principal.
for (int i = 0; i < N; i++)                // Laço seguindo índices da diagonal (linha = coluna).
{
    Write(matriz[i, i] + " ");             // Imprime elemento da diagonal principal e espaço.
}

// Contar negativos
int negativos = 0;                         // Inicializa contador de números negativos.

for (int i = 0; i < N; i++)                // Laço para cada linha.
{
    for (int j = 0; j < N; j++)            // Laço para cada coluna.
    {
        if (matriz[i, j] < 0)              // Se o elemento for negativo...
        {
            negativos++;                  // ...incrementa o contador.
        }
    }
}

WriteLine();                               // Quebra de linha antes do resultado.
WriteLine("Quantidade de negativos: " + negativos); // Exibe total de negativos encontrados.