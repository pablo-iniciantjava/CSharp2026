using RetanguloComPOO;
// Importa o namespace onde está a classe Retangulo

using static System.Console;
// Permite usar WriteLine e Write diretamente sem precisar escrever Console.WriteLine

Retangulo x = new Retangulo();
// Cria um objeto chamado x da classe Retangulo

Retangulo Y = new Retangulo();
// Cria um segundo objeto chamado Y da classe Retangulo

WriteLine("Digite os dados do retangulo X");
// Mostra uma mensagem pedindo os dados do primeiro retângulo

Write("Digite a largura: ");
// Mostra no console a mensagem pedindo a largura

x.Largura = double.Parse(Console.ReadLine());
// Lê o valor digitado pelo usuário, converte para double e armazena no atributo Largura do objeto x

Write("Digite a altura: ");
// Mostra no console a mensagem pedindo a altura

x.Altura = double.Parse(Console.ReadLine());
// Lê o valor digitado, converte para double e guarda no atributo Altura do objeto x

WriteLine("Digite os dados do retangulo Y");
// Mostra mensagem pedindo os dados do segundo retângulo

Write("Digite a largura: ");
// Pede ao usuário a largura do retângulo Y

Y.Largura = double.Parse(Console.ReadLine());
// Lê o valor digitado e armazena no atributo Largura do objeto Y

Write("Digite a altura: ");
// Pede ao usuário a altura do retângulo Y

Y.Altura = double.Parse(Console.ReadLine());
// Lê o valor digitado e armazena no atributo Altura do objeto Y

WriteLine($"Area do retangulo X = {x.Area()}");
// Chama o método Area() do objeto x e mostra o resultado na tela

WriteLine($"Perimetro do retangulo X = {x.Perimetro()}");
// Chama o método Perimetro() do objeto x e mostra o resultado

WriteLine($"Diagonal do retangulo X = {x.Diagonal()}");
// Chama o método Diagonal() do objeto x e mostra o resultado

WriteLine($"Area do retangulo Y = {Y.Area()}");
// Chama o método Area() do objeto Y e mostra o resultado

WriteLine($"Perimetro do retangulo Y = {Y.Perimetro()}");
// Chama o método Perimetro() do objeto Y e mostra o resultado

WriteLine($"Diagonal do retangulo Y = {Y.Diagonal()}");
// Chama o método Diagonal() do objeto Y e mostra o resultado