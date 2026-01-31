class PagamentoBoleto : PessoaPagamentos, IPagamento{
        
    public PagamentoBoleto(string nome, string email) : base (nome, email)
    {
        
    }

    public void ProcessarPagamento()
    {
        Console.WriteLine($"Processando pagamento via boleto para {this.Nome} - {this.Email}");
    }
}