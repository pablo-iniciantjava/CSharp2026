using static System.Console;
// ------------------Declaração de variáveis------------------
double A, B, C,areaQuadrado, areaRetangulo, areaTrapezio;

// ------------------Entrada de dados------------------
Write("Digite a medida A: ");
A = double.Parse(ReadLine());
Write("Digite a medida B: ");
B = double.Parse(ReadLine());
Write("Digite a medida C: ");
C = double.Parse(ReadLine());

// ------------------Processamento de dados------------------
areaQuadrado = A * A;
areaRetangulo = (A * B)/2;
areaTrapezio = (A + B) * C / 2;

// ------------------Saída de dados--------------------------
WriteLine($"Área do quadrado: {areaQuadrado}");
WriteLine($"Área do retângulo: {areaRetangulo}");
WriteLine($"Área do trapézio : {areaTrapezio} Medidada Final");

// ------------------Formatar dados------------------







