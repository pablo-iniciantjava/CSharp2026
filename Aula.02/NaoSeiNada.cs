// Declara três variáveis do tipo double para armazenar dois números e o cálculo da média
double x, y, media;

// Exibe uma mensagem pedindo ao usuário que digite o primeiro número
Console.WriteLine("Digite o primeiro numero: ");

// Lê a entrada do usuário, converte para double e armazena em x
x = double.Parse(Console.ReadLine());

// Exibe uma mensagem pedindo ao usuário que digite o segundo número
Console.WriteLine("Digite o segundo numero: ");

// Lê a entrada do usuário, converte para double e armazena em y
y = double.Parse(Console.ReadLine());

// Calcula a média aritmética entre x e y (soma dividida por 2) e armazena em media
media = (x + y) / 2.0;

// Exibe o resultado da média no console, concatenando a string com o valor de media
Console.WriteLine("Media = " + media);
