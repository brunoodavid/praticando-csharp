class Freelancer : Funcionario
{
    public double ValorProjeto { get; }

    public Freelancer(string nome, string cargo, double valorProjeto) : base(nome, cargo)
    {
        this.ValorProjeto = valorProjeto;
    }
}