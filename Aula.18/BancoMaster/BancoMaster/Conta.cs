namespace BancoMaster // Organização do projeto
{
    internal class Conta // Classe base
    {
        // Propriedades da conta
        public int Numero { get; set; } // Número da conta
        public string Titular { get; set; } // Nome do titular
        public double Saldo { get; set; } // Saldo da conta

        // Construtor sem saldo inicial
        public Conta(int numero, string titular)
        {
            Numero = numero; // Atribui número
            Titular = titular; // Atribui titular
            Saldo = 0; // Saldo inicial 0
        }

        // Construtor com saldo inicial
        public Conta(int numero, string titular, double saldo)
        {
            Numero = numero; // Atribui número
            Titular = titular; // Atribui titular
            Saldo = saldo; // Saldo inicial definido
        }

        // Método de saque (cobre taxa de 5)
        public void Saque(double quantia)
        {
            Saldo -= (quantia + 5.0); // Retira valor + taxa
        }

        // Método de depósito
        public void Deposito(double quantia)
        {
            Saldo += quantia; // Adiciona valor ao saldo
        }

        // Método para exibir os dados da conta
        public void Dados()
        {
            Console.WriteLine("Dados da conta:");
            Console.WriteLine($"Conta: {Numero}");
            Console.WriteLine($"Titular: {Titular}");
            Console.WriteLine($"Saldo: {Saldo:C}");
            Console.WriteLine("---------------------------");
        }
    }
}