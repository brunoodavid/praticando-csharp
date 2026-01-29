class Passageiro : Pessoa
{
    public int QuantidadeDeBilhetes { get; }

    public Passageiro(string nome, int idade, int quantidadeDeBilhetes) : base(nome, idade)
    {
        this.QuantidadeDeBilhetes = quantidadeDeBilhetes;
    }

    public void ExibirDados()
    {
        Console.WriteLine($"Passageiro: {base.Nome} - Idade: {base.Idade} - Bilhetes: {QuantidadeDeBilhetes}");
    }
}