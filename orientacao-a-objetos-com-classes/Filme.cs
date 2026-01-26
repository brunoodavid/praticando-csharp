class Filme
{
    public string? Titulo { get; set; }
    public int ClassificacaoEtaria { get; set; }

    public Filme(string titulo, int classificacaoEtaria)
    {
        Titulo = titulo;
        ClassificacaoEtaria = classificacaoEtaria;
    }

    public bool PodeAssistir(int idadeUsuario)
    {
        if (idadeUsuario < ClassificacaoEtaria)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public void ExibirResultado(int idade)
    {
        if (PodeAssistir(idade))
        {
            Console.WriteLine($"Usuário com {idade} anos pode assistir ao filme Matrix.");
        }
        else
        {
            Console.WriteLine($"Usuário com {idade} anos não pode assistir ao filme Matrix.");
        }
    }
}