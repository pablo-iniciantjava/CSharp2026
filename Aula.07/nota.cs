using static System.Console;
// ============================================ DECLARAÇÃO DE VARIÁVEIS ============================================
double nota1, nota2, resultado;

// ============================================ ENTRADA DE DADOS ============================================
Write("Digite a nota 1º nota: ");
nota1 = double.Parse(ReadLine());
Write("Digite a nota 2º nota: ");
nota2 = double.Parse(ReadLine());   
// ============================================ PROCESSAMENTO DE DADOS ============================================
resultado = nota1 + nota2;

if (resultado < 60)
{
    WriteLine($"Nota final: {resultado:F2}");
    WriteLine("Reprovado");
}
else 
{
  WriteLine($"Nota final: {resultado:F2}");
    WriteLine("Aprovado");
}