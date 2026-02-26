using static System.Console;
//---------------------------------------------DECLARAÇÃO DE VARIÁVEIS---------------------------------------------
double a, b, c, p, area, areaT;

//---------------------------------------------ENTRADA DE DADOS---------------------------------------------
WriteLine("Digite o valor de a: ");
a = double.Parse(ReadLine());
WriteLine("Digite o valor de b: ");
b = double.Parse(ReadLine());
WriteLine("Digite o valor de c: "); 
c = double.Parse(ReadLine());

//---------------------------------------------PROCESSAMENTO DE DADOS---------------------------------------------
if (a < b + c && b < a + c && c < a + b) // verifica se forma triângulo
{
    p = (a + b + c) / 2;                  // semiperímetro
    area = Math.Sqrt(p * (p - a) * (p - b) * (p - c)); // área do triângulo
    areaT = ((a + b) * c) / 2;            // área do trapézio

    //-----------------------------------------SAÍDA DE DADOS--------------------------------
    WriteLine("Os valores formam um triângulo!");
    WriteLine($"Semiperímetro = {p}");
    WriteLine($"Área do triângulo = {area}");
    WriteLine($"Área do trapézio = {areaT}");
}
else
{
    WriteLine("Os valores NÃO formam um triângulo.");
}