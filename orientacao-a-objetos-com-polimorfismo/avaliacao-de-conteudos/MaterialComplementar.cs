public class MaterialComplementar : Conteudo
{
    public int Paginas { get;set;}

    public MaterialComplementar(string titulo, int paginas) : base(titulo)
    {
        this.Paginas = paginas;
    }

    public override void ExibirInfo()
    {
        Console.WriteLine($"Título: {base.Titulo}");
        Console.WriteLine($"Páginas: {Paginas}");
    }
} 