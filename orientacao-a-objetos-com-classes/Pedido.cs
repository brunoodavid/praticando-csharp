class Pedido
{
    public string? NumeroPedido { get; set; }
    public string? NomeCliente { get; set; }
    public string? Status {get; set;}

    public Pedido(string numeroPedido, string nomeCliente, string status)
    {
        NumeroPedido = numeroPedido;
        NomeCliente = nomeCliente;
        Status = status;
    }

    public void AtualizarPedido(string novoStatus)
    {
        Status = novoStatus;
    }

    public void ExibirPedido()
    {
        Console.WriteLine($"Pedido numero: {NumeroPedido}");
        Console.WriteLine($"Cliente: {NomeCliente}");
        Console.WriteLine($"Status: {Status}");
    }
}