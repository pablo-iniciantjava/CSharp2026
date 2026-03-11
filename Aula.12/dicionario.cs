using static System.Console;

//-----------Declaração de um dicionário-----------------

Dictionary<string, int> pessoas = new Dictionary<string, int>()
{
    {"João", 25},
    {"Maria", 30},
    {"Pedro", 28}

};
//Adicionando dados ao dicionário//
pessoas.Add("Clodoaldo", 54);
WriteLine($"Tamanho = {pessoas.Count}");
WriteLine($"{pessoas["Clodoaldo"]}"); 
WriteLine($"Tamanho = {pessoas.Count}");
pessoas.Remove("Clodoaldo");
WriteLine($"Tamanho = {pessoas.Count}");