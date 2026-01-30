class Pergaminho : ItemDigital
{
    public string ConteudoTextual { get; set;}

    public Pergaminho(string titulo, string conteudoTextual) : base(titulo)
    {
        this.ConteudoTextual = conteudoTextual;
    }

    public void mostrarDetalhes()
    {
        Console.WriteLine("Detalhes do Pergaminho: ");
        Console.WriteLine($"Titulo: {this.Titulo}");
        Console.WriteLine($"Descrição: {this.ConteudoTextual}");
    }
}