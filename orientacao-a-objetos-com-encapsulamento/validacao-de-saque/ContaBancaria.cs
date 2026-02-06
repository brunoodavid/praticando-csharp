public class ContaBancaria
{
    public string Titular { get; set; }
    private double _saldo;
    public double Saldo { get { return _saldo; } }

    public ContaBancaria(string titular, double saldo)
    {
        this.Titular = titular;
        if (saldo < 0)
        {
            Console.WriteLine($"Erro: Saldo não pode ser negativo.!");
        }
        this._saldo = saldo;

    }

    public void Sacar(double valorASacar)
    {
        if (valorASacar < 0 || valorASacar > _saldo)
        {
            Console.WriteLine("Erro: saque não pode ser negativo e/ou não tem este valor para sacar.");
        }
        if (SegurancaConta.ValidarSaque(valorASacar))
        {
            _saldo -= valorASacar;
            Console.WriteLine("Saque realizado com sucesso.");
        }
    }
}