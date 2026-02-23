var diasDaSemana = new string[] { "Domingo", "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado" };

var carrinho = new List<Produto>()
{
    new Produto(){ Nome = "Leite", Preco = 3.99},
    new Produto() { Nome = "Manteiga", Preco = 3.99 }
};

class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }
}
