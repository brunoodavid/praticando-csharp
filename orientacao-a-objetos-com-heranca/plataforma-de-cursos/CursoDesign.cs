class CursoDesign : ICurso
{
    public string TipoCurso {get;}
    public Instrutor Instrutor { get;}

    public CursoDesign(string tipoCurso, Instrutor instrutor)
    {
        this.TipoCurso = tipoCurso;
        this.Instrutor = instrutor;
    }

    public void ValidarConteudo()
    {
        Console.WriteLine($"Validando conteúdo do curso de design: {TipoCurso}");
    }

    public void PublicarCurso()
    {
        Console.WriteLine($"Curso publicado com sucesso: {TipoCurso} - Instrutor: {this.Instrutor.Nome} ({this.Instrutor.Especialidade})");
    }
}