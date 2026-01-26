class Funcionario
{
    public string? Nome;
    public string? Cargo;

    public Funcionario(string nome, string cargo)
    {
        Nome = nome;
        Cargo = cargo;
    }

    public void mostrarDados()
    {
        Console.WriteLine(Nome);
        Console.WriteLine(Cargo);
    }

    public void promover(string novoCargo)
    {
        if (Cargo == novoCargo)
        {
            Console.WriteLine("Erro, o cargo atual não pode ser o mesmo que o novo cargo");
        }

        Cargo = novoCargo;
    }
}