public class Interno : Funcionario
{
    public double Salario { get; private set; }

    public Interno(string nome, string cargo, double salario) : base(nome, cargo)
    {
        this.Salario = salario;
    }
}