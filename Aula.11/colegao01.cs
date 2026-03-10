int [] numeros = new int [5];
string [] nomes = new string ["João","Maria","Pedro","Ana","Lucas"];

        Console.WriteLine(nomes[2]);

        numeros[0] = 10;
        numeros[1] = 10;

        Console.WriteLine(numeros[1]);

        numeros[2] = 0;
        numeros[3] = 5;
        numeros[4] = 7;

        int tamanho = numeros.Length;
        Console.WriteLine("O tamanho do vetor é: " + tamanho);