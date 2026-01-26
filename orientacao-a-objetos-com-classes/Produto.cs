class Produto
{
    public string? NomeProduto { get; set; }
    public int QuantidadeEstoque { get; set; }

    public Produto(string nomeProduto, int quantidadeEstoque)
    {
        NomeProduto = nomeProduto;
        QuantidadeEstoque = quantidadeEstoque;
    }

    public void RetirarProdutoEstoque(int quantidade)
    {
        if (QuantidadeEstoque >= quantidade)
        {
            QuantidadeEstoque -= quantidade;
            Console.WriteLine($"Retirada de {quantidade} unidades realizada com sucesso.");
            Console.WriteLine($"Produto: {NomeProduto}");
            Console.WriteLine($"Estoque: {QuantidadeEstoque}");
        }
        else
        {
            Console.WriteLine($"Erro: Estoque insuficiente para retirada de {quantidade} unidades.");
        }
    }
}