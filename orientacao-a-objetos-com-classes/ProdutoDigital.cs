class ProdutoDigital
{
    public string? Nome { get; set; }
    public double Preco { get; set; }
    public InformacaoTecnica Info { get; set; }

    public ProdutoDigital(string nome, double preco, InformacaoTecnica info)
    {
        Nome = nome;
        Preco = preco;
        Info = info;    
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Produto: {Nome}");
        Console.WriteLine($"Preço {Preco}");
        Console.WriteLine($"Tamanho: {Info.TamanhoMB}");
        Console.WriteLine($"Compatível com: {Info.SistemaOperacional}");
    }
}