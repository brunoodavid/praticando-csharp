class Curso
{
    public string Nome { get; set; }    
    public int VagasTotais { get; set; }
    private List<EstudanteMatricula> _estudantes = new List<EstudanteMatricula>();
    public int VagasDisponiveis { get {return VagasTotais - _estudantes.Count;}}

    public Curso(string nome, int vagasTotais)
    {
        this.Nome = nome;
        this.VagasTotais = vagasTotais;
    }

    public bool Matricular(EstudanteMatricula estudante)
    {
        if(VagasDisponiveis > 0)
        {
            _estudantes.Add(estudante);
            Console.WriteLine("Estudante matriculado com sucesso.");
            return true;
        } else
        {
            Console.WriteLine("Erro: Não há vagas disponiveis para este curso.");
            return false;
        }
    }
    public void ListarMatriculados()
    {
        Console.WriteLine($"Estudantes matriculados em {Nome}");
        foreach(var estudante in _estudantes)
        {
            Console.WriteLine($"- {estudante.Nome}");
        }
        Console.WriteLine($"Vagas disponíveis: {VagasDisponiveis}");
    }
}