using System.Collections;

var carrinho = new List<Produto>()
{
    new Produto(){ Nome = "Leite", Preco = 3.99},
    new Produto() { Nome = "Manteiga", Preco = 3.99 }
};

var diasDaSemana = new DiasDaSemana(); 

foreach(var dia in diasDaSemana)
{
    Console.WriteLine(dia);
}
//PercorrendoComForEach();

void PercorrendoComFor()
{
    for(int i = 0; i < carrinho.Count; i++)
    {
        var produto = carrinho[i];
        Console.WriteLine($"Produto: {produto.Nome}");
    }
}

void PercorrendoComForEach()
{
    foreach(var produto in carrinho)
    {
        Console.WriteLine($"Produto: {produto.Nome}");
    }
}
class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }
}

class DiasDaSemanaEnumarator : IEnumerator<string>
{
    private int _posicao = -1;
    private string[] dias = { "Domingo", "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado" };
    public string Current => dias[_posicao];

    object IEnumerator.Current => Current;

    public void Dispose()
    {
        
    }

    public bool MoveNext()
    {
        _posicao++;
        return _posicao < dias.Length;
    }

    public void Reset()
    {
        _posicao = -1;
    }
}

class DiasDaSemana : IEnumerable<string>
{
    public IEnumerator<string> GetEnumerator()
    {
        return new DiasDaSemanaEnumarator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}