public class Imagem : Midia
{
    public string Resolucao { get; set; }

    public Imagem(string nome, string resolucao) : base(nome)
    {
        this.Resolucao = resolucao;
    }

    public override void ExibirDetalhes()
    {
        Console.WriteLine($"Imagem: {Nome} - Resolução: {Resolucao}");
    }
}

