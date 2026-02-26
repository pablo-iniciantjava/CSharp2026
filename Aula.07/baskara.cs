using static System.Console;
//---------------------------------------------DECLARAÇÃO DE VARIÁVEIS---------------------------------------------
double a, b, c;

//---------------------------------------------ENTRADA DE DADOS---------------------------------------------
WriteLine("Digite o valor de a: ");
a = double.Parse(ReadLine());
WriteLine("Digite o valor de b: ");
b = double.Parse(ReadLine());
WriteLine("Digite o valor de c: "); 
c = double.Parse(ReadLine());
//---------------------------------------------PROCESSAMENTO DE DADOS---------------------------------------------
if (a < b + c && b < a + c && c < a + b)
//-----------------------------------------ESTRUTURA DE CONTROLE DE DECISAO - IF--------------------------------
if (delta < 0)
{
    WriteLine("Raizes impossiveis");
}
else if (delta == 0)
{
    x1 = -b / (2 * a);
    x2 = x1;
    WriteLine($" X1 =  {x1}\nX2 = {x2}");
}
else
{
    x1 = (-b - Math.Sqrt(delta)) / (2 * a);
    x2 = (-b + Math.Sqrt(delta)) / (2 * a);
    WriteLine($" X1 =  {x1}\n X2 = {x2}");
}













