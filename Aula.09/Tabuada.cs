using static System.Console;


//---------------------------------------------DECLARAÇÃO DE VARIÁVEIS---------------------------------------------
int numero;
//---------------------------------------------ENTRADA DE DADOS---------------------------------------------
numero = int.Parse(ReadLine());
//---------------------------------------------PROCESSAMENTO DE DADOS---------------------------------------------
for (int i = 0; i <= 10; i++)
{
    WriteLine($"{numero} X {i+1} = {numero * (i + 1)}");
}