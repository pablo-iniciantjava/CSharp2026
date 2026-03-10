using static System.Console;


//---------------------------------------------DECLARAÇÃO DE VARIÁVEIS---------------------------------------------
const int SENHAFIXA = 2002; // Constante para a senha fixa
int senha;  // Variável para armazenar a senha digitada pelo usuário  
int contagem = 0;

Write("Digite a senha: ");
senha = int.Parse(ReadLine()); // Lê a senha digitada e converte para inteiro


while (senha != SENHAFIXA) // Loop continua enquanto a senha for incorreta
{
    if (contagem >= 3) 
    {
        Beep(1000, 800); // 🔊 apita quando bloqueia
        WriteLine("Número de tentativas excedido. Acesso bloqueado.");
        break;
    }

    {
        WriteLine("Senha incorreta, digite novamente.");
        Beep(500, 300); 
        senha = int.Parse(ReadLine());
        contagem++;
        break;
    }
}


// Verifica se o número de tentativas excedeu o limite
if (contagem >= 3)
{
    Beep(1000, 800); // 🔊 apita novamente ao confirmar bloqueio
    WriteLine("Número de tentativas excedido. Acesso bloqueado.");
}
else if (senha == SENHAFIXA) // Verifica se a senha é correta
{
    WriteLine("Acesso permitido."); // Mensagem de acesso permitido após a senha correta ser digitada123