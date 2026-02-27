using static System.Console;

//---------------------------------------------FUNÇÕES---------------------------------------------
static double delta(double a, double b, double c)

{
    return (b * b)- (4 * a * c);
}

static void saida(double x1, double x2)
{
    WriteLine($" X1 = {x1}\n X2 = {x2}");                  
}
static void raizes(double a, double b, double delta)
{
    double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
    double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
    saida(x1, x2);
}
//---------------------------------------------DECLARAÇÃO DE VARIÁVEIS---------------------------------------------
double a, b, c, delta1;
const string TEXT = "Digite o valor de ";

//---------------------------------------------ENTRADA DE DADOS---------------------------------------------
Write("TEXTO + a: ");
a = double.Parse(ReadLine());
Write("TEXTO + b: ");
b = double.Parse(ReadLine());
Write("TEXTO + 36c:");
c = double.Parse(ReadLine());
//---------------------------------------------PROCESSAMENTO DE DADOS---------------------------------------------
delta1 = delta ( a, b, c); 
//---------------------------------------------Estrutura de Controle de decisão---------------------------------------------
if (delta1 < 0) 
{
    WriteLine(" Raizes impossíveis");
}
else if (delta1 == 0)
{
   raizes(a, b, delta1);
}
else
{ raizes(a, b, delta1);
}

   