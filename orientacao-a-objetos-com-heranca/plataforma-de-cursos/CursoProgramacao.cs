class CursoProgramacao : ICurso
{
    public string TipoCurso { get; }
    public Instrutor Instrutor { get;}
    
    public CursoProgramacao(string tipoCurso, Instrutor instrutor)
    {
        this.TipoCurso = tipoCurso;
        this.Instrutor = instrutor;
    }

    public void ValidarConteudo()
    {
        Console.WriteLine($"Validando conteúdo do curso de programação: {this.TipoCurso}");
    }

    public void PublicarCurso()
    {
        Console.WriteLine($"Curso publicado com sucesso: {this.TipoCurso} - Instrutora: {this.Instrutor.Nome} ({this.Instrutor.Especialidade})");
    }
}