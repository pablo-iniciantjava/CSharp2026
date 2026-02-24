using static System.Console;

// ============================================ DECLARAÇÃO DE VARIÁVEIS ============================================
// Declara três variáveis inteiras para armazenar os valores do usuário
int a, b, c;

// ============================================ ENTRADA DE DADOS ============================================
// Solicita o primeiro valor ao usuário
Write("Digite o primeiro valor: ");
a = int.Parse(ReadLine());

// Solicita o segundo valor ao usuário
Write("Digite o segundo valor: ");
b = int.Parse(ReadLine());

// Solicita o terceiro valor ao usuário
Write("Digite o terceiro valor: ");
c = int.Parse(ReadLine());

// ============================================ PROCESSAMENTO - PERGUNTAS SIMPLES ============================================
// Verifica se o primeiro valor é igual ao terceiro valor
bool resposta1 = (a == c);

// Verifica se o segundo valor é diferente do primeiro valor
bool resposta2 = (b != a);

// Verifica se o segundo valor é maior que o terceiro valor
bool resposta3 = (b > c);

// Verifica se o primeiro valor é menor ou igual ao terceiro valor
bool resposta4 = (a <= c);

// ============================================ SAÍDA DE DADOS - PERGUNTAS SIMPLES ============================================
// Exibe o título da seção
WriteLine("\nPERGUNTAS SIMPLES:");

// Exibe o resultado da pergunta 1
WriteLine($"1- O primeiro valor é igual ao terceiro valor? {resposta1}");

// Exibe o resultado da pergunta 2
WriteLine($"2- O segundo valor é diferente do primeiro valor? {resposta2}");

// Exibe o resultado da pergunta 3
WriteLine($"3- O segundo valor é maior que o terceiro valor? {resposta3}");

// Exibe o resultado da pergunta 4
WriteLine($"4- O primeiro valor é menor ou igual ao terceiro valor? {resposta4}");

// ============================================ SAÍDA DE DADOS - PERGUNTAS COMPOSTAS ============================================
// Exibe o título da seção
WriteLine("\nPERGUNTAS COMPOSTAS:");

// Verifica se a 1ª pergunta E a 3ª pergunta são ambas verdadeiras (operador AND - &&)
WriteLine($"1- 1ª pergunta E 3ª pergunta são verdadeiras? {resposta1 && resposta3}");

// Verifica se a 2ª pergunta OU a 4ª pergunta é pelo menos uma verdadeira (operador OR - ||)
WriteLine($"2- 2ª pergunta OU 4ª pergunta é verdadeira? {resposta2 || resposta4}");

// Verifica se a negação da 1ª pergunta é verdadeira (operador NOT - !)
WriteLine($"3- Negação da 1ª pergunta é verdadeira? {!resposta1}");



