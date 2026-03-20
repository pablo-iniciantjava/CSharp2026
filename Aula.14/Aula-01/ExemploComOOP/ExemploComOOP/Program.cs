//PROGRAMAÇÃO ORIENTADA A OBJETOS

using ExemploComOOP;
using static System.Console;

Triangulo x = new Triangulo();
Triangulo Y = new Triangulo();

// Isso é atribuição a classe ?
WriteLine("Digite as medidas do triangulo X");

Write("Digite a medida A: ");
x.ladoA = double.Parse(ReadLine());


Write("Digite a medida B: ");
x.ladoB = double.Parse(ReadLine());

Write("Digite a medida C: ");
x.ladoC = double.Parse(ReadLine());

// Como posso definir este  ?
WriteLine("Digite as medidas do triangulo Y");

WriteLine("Digite as medidas do triangulo A");
Write("Digite a medida de A: ");
Y.ladoA=double.Parse(ReadLine());
WriteLine("Digite as medidas do triangulo B");
Write("Digite a medida de B: ");
Y.ladoA = double.Parse(ReadLine());
WriteLine("Digite as medidas do triangulo C");
Write("Digite a medida de C: ");
Y.ladoA = double.Parse(ReadLine());

//Saída de dados 

WriteLine("A area do triangulo X é de {x.Area()}");
WriteLine("A area do triangulo Y é de {x.Area()}");














