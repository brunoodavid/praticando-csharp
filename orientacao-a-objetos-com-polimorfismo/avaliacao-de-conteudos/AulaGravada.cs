public class AulaGravada : Conteudo
{
    public int DuracaoAula { get; set;}

    public AulaGravada(string titulo, int duracaoAula) : base(titulo)
    {
        this.DuracaoAula = duracaoAula;
    }

    public override void ExibirInfo()
    {
        Console.WriteLine($"Título: {base.Titulo}.");
        Console.WriteLine($"Duração: {DuracaoAula} min.");
    }
}