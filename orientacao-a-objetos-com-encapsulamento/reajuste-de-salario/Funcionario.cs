class Funcionario
{
    public string Nome { get; set; }
    private double _salario;
    public double Salario { get { return _salario; } }
    public Funcionario(string nome, double salarioInicial)
    {
        this.Nome = nome;
        this._salario = salarioInicial;
    }

    public void ReajustarSalario(double novoSalario)
    {
        if (this._salario < novoSalario)
        {
            Console.WriteLine($"Erro: O novo salário deve ser maior que o atual.");
        }

        this._salario = novoSalario;
    }
}