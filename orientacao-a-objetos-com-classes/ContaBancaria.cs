class ContaBancaria
{
    public string NumeroConta;
    public double Saldo;

    public ContaBancaria(string numeroDaConta, double saldo)
    {
        NumeroConta = numeroDaConta;
        Saldo = saldo;
    }

    public void Depositar(double deposito)
    {
        Saldo += deposito;
    }
}