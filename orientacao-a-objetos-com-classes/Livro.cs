public class Livro
{
    public string? Titulo { get; set; }
    public string? Autor { get; set; }
    public static void cadastrarLivros()
    {
        Livro meuLivro = new Livro();
        string titulo = meuLivro.Titulo = "Dom Casmurro";
        string autor = meuLivro.Autor = "Machado de Assis";

        Console.WriteLine($"Livro: {titulo}");
        Console.WriteLine($"Autor: {autor}");
    }
}