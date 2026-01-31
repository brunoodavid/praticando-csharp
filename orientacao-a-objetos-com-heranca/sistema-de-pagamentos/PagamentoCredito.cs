class PagamentoCredito : PessoaPagamentos, IPagamento
{
    public PagamentoCredito(string nome, string email) : base (nome, email)
    {
        
    }

    public void ProcessarPagamento()
    {
        Console.WriteLine($"Processando pagamento com cartão de crédito para {this.Nome} - {this.Email}");
    }
}