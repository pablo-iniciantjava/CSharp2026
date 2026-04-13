namespace BancoMaster
{
    internal class ContaParaEmpresa : Conta // Herda da Conta
    {
        public double LimiteDeEmprestimo { get; set; } // Limite de empréstimo

        // Construtor sem saldo
        public ContaParaEmpresa(int numero, string titular, double limite)
            : base(numero, titular)
        {
            LimiteDeEmprestimo = limite; // Define limite
        }

        // Construtor com saldo
        public ContaParaEmpresa(int numero, string titular, double saldo, double limite)
            : base(numero, titular, saldo)
        {
            LimiteDeEmprestimo = limite; // Define limite
        }

        // Método de empréstimo
        public void Emprestimo(double quantia)
        {
            Saldo += quantia; // Adiciona valor ao saldo
        }
    }
}