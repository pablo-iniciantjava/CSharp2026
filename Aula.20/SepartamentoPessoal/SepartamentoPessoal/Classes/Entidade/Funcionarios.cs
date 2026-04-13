namespace DepartamentoPessoal.Classes.Entidade
{
    internal class Funcionario
    {
        // Campos
        private string nome;
        private int jornada;
        private double valor;

        // Propriedades
        public string NomeColaborador
        {
            get { return nome; }
            set { nome = value; }
        }

        public int JornadaTrabalho
        {
            get { return jornada; }
            set { jornada = value; }
        }

        public double ValorHora
        {
            get { return valor; }
            set { valor = value; }
        }

        // Construtor
        public Funcionario(string nomeColaborador, int jornadaTrabalho, double valorHora)
        {
            NomeColaborador = nomeColaborador;
            JornadaTrabalho = jornadaTrabalho;
            ValorHora = valorHora;
        }

        // Métodos
        public virtual double Pagamento()
        {
            return ValorHora * JornadaTrabalho;
        }

        public override string ToString()
        {
            return $"{NomeColaborador} - {Pagamento():C}";
        }
    }
}