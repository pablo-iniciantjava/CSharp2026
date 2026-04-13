namespace BancoMaster
{
    internal class ContaPoupanca : Conta // Herda da Conta
    {
        public double TaxaDeJuros { get; set; } // Taxa de juros

        // Construtor sem saldo
        public ContaPoupanca(int numero, string titular, double taxa)
            : base(numero, titular) // Chama construtor da classe base
        {
            TaxaDeJuros = taxa; // Define a taxa
        }

        // Construtor com saldo inicial
        public ContaPoupanca(int numero, string titular, double saldo, double taxa)
            : base(numero, titular, saldo) // Chama base com saldo
        {
            TaxaDeJuros = taxa; // Define taxa
        }

        // Método para atualizar saldo com juros
        public void AtualizacaoDeSaldo()
        {
            Saldo += Saldo * TaxaDeJuros; // Saldo + juros
        }

        // Método de saque (não cobra taxa)
        public void SaquePoupanca(double quantia)
        {
            Saldo -= quantia; // Retira apenas valor
        }
    }
}