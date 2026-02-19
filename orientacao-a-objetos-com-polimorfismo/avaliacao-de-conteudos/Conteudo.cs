public class Conteudo
{
    public string Titulo { get; set; }  
    
    public Conteudo(string titulo)
    {
        this.Titulo = titulo;
    }

    public virtual void ExibirInfo()
    {
        Console.WriteLine($"Titulo do conteudo genérico: {Titulo}");
    }
}