using static System.Console;

///---------------------------------------------DECLARAÇÃO DE VARIÁVEIS---------------------------------------------

// Guarda a quantidade total de pessoas que irão informar a altura
int quantidadePessoas;

// Guarda a altura mínima permitida para andar na montanha-russa
double alturaMinima;

// Guarda a altura máxima permitida para andar na montanha-russa
double alturaMaxima;

// Guarda a altura digitada de uma pessoa por vez (usada dentro do laço)
double alturaPessoa;

// Contador que começa em 0 e será incrementado
// cada vez que uma pessoa estiver dentro do intervalo permitido
int contador = 0;

//---------------------------------------------ENTRADA DE DADOS---------------------------------------------
try
{
    // Entrada do número de pessoas
    Write("Quantas pessoas irão informar a altura ?: ");
    quantidadePessoas = int.Parse(ReadLine()); // Continua int, pois é um número inteiro

    // Entrada da altura mínima (agora aceita números com casas decimais)
    Write("Qual a altura mínima permitida para andar na montanha-russa ?: ");
    alturaMinima = double.Parse(ReadLine(), System.Globalization.CultureInfo.CurrentCulture);

    // Entrada da altura máxima (agora aceita números com casas decimais)
    Write("Qual a altura máxima permitida para andar na montanha-russa ?: ");
    alturaMaxima = double.Parse(ReadLine(), System.Globalization.CultureInfo.CurrentCulture);

    //---------------------------------------------PROCESSAMENTO DE DADOS---------------------------------------------
    for (int i = 0; i < quantidadePessoas; i++)
    {
        // Entrada da altura da pessoa atual
        Write($"Digite a altura da {i + 1}ª pessoa: ");
        alturaPessoa = double.Parse(ReadLine(), System.Globalization.CultureInfo.CurrentCulture);

        // Verifica se a pessoa está dentro do intervalo permitido
        if (alturaPessoa >= alturaMinima && alturaPessoa <= alturaMaxima)
        {
            contador++; // Incrementa contador se a pessoa puder andar
        }
    }

    //---------------------------------------------SAÍDA DE DADOS---------------------------------------------
    WriteLine($"A quantidade de pessoas que podem andar na montanha-russa é: {contador}");
}
catch (Exception ex)
{
    // Mensagem de erro caso a entrada seja inválida
    WriteLine($"Digite valores válidos, erro: {ex.Message}");
}


