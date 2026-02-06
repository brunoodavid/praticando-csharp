class Projeto
{
    public string Nome { get; set; }
    private List<string> _tarefas = new List<string>();

    public Projeto(string nome)
    {
        this.Nome = nome;
    }

    public void AdicionarTarefa(string novaTarefa)
    {
        _tarefas.Add(novaTarefa);
    }

    public void ExibirTarefas()
    {
        Console.WriteLine($"Projeto: {this.Nome}");
        Console.WriteLine("Tarefas: ");

        foreach (var tarefa in _tarefas)
        {
            Console.WriteLine($"- {tarefa}");
        }

        Console.WriteLine($"Total: {_tarefas.Count}");
    }


}