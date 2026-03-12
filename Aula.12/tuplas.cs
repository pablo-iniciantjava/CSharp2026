// Tuplas em C#

var clodoaldo = ("Clodoaldo", 34, 5000.34, "Heitor", "SENAI", 'B'); // Criando uma tupla com nome, idade e profissão

System.Console.WriteLine($"Idade do clodoaldo: {clodoaldo.Item1}"); // Imprime a tupla completa
System.Console.WriteLine($"Idade do clodoaldo: {clodoaldo.Item2}");
System.Console.WriteLine($"Nome do filho do clodoaldo: {clodoaldo.Item3}"); 
clodoaldo.Item1 = 54; // Acessando o nome do filho do clodoaldo
System.Console.WriteLine($"Idade do clodoaldo: {clodoaldo.Item1}"); // Imprime a idade do clodoaldo

(int, int, int) numeros = (1, 2, 5); // Criando uma tupla de números inteiros

System.Console.WriteLine($"Números: {numeros.Item1 + numeros.Item2 + numeros.Item3}"); // Imprime a soma dos números da tupla 