using System.Collections;

var carrinho = new List<Produto>()
{
    new Produto(){ Nome = "Leite", Preco = 3.99},
    new Produto() { Nome = "Manteiga", Preco = 3.99 }
};

var diasDaSemana = new DiasDaSemana();


//PercorrendoComForEach();
// percorrendoComEnumarator();

var numerosPares = NumerosParesComYield();
var contador = 0;
foreach (var pares in numerosPares)
{
    contador++;
    Console.WriteLine(pares);
    if (contador > 5) break;
}

IEnumerable<int> NumerosParesComYield()
{
    var i = 0;
    while (true)
    {
        Console.WriteLine($"Processando elemento {i} ...");
        yield return i * 2;
        if (i >= 100)
        {
            yield break;
        }
        i++;
    }
}

IEnumerable<int> NumerosParesSemYield(int limite)
{
    var Lista = new List<int>();
    for (int i = 0; i < limite; i++)
    {
        Console.WriteLine($"Processando elemento {i} ...");
        Lista.Add(i * 2);
    }

    return Lista;
}

void percorrendoComEnumarator()
{
    var enumarator = diasDaSemana.GetEnumerator();
    while (enumarator.MoveNext())
    {
        var dia = enumarator.Current;
        Console.WriteLine(dia);
    }
}

void percorrendoDiasDaSemana()
{
    foreach (var dia in diasDaSemana)
    {
        Console.WriteLine(dia);
    }
}

void PercorrendoComFor()
{
    for (int i = 0; i < carrinho.Count; i++)
    {
        var produto = carrinho[i];
        Console.WriteLine($"Produto: {produto.Nome}");
    }
}

void PercorrendoComForEach()
{
    foreach (var produto in carrinho)
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
        yield return "Domingo";
        yield return "Segunda";
        yield return "Terça";
        yield return "Quarta";
        yield return "Quinta";
        yield return "Sexta";
        yield return "Sábado";
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}