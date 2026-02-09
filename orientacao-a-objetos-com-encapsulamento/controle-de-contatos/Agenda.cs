class Agenda
{
    public string Proprietario { get; set; }
    private readonly List<Contato> _contatos = new List<Contato>();
    public int QuantidadeContatos { get; }

    public Agenda(string proprietario)
    {
        this.Proprietario = proprietario;
    }

    public bool AdicionarContato(Contato contato)
    {
        if (_contatos.Any(c => c.Nome == contato.Nome))
        {
            Console.WriteLine($"Já existe este contato na lista");
            return false;
        }

        _contatos.Add(contato);
        Console.WriteLine($"Contato adicionado com Sucesso!");
        return true;
    }

    public void ListarContatos()
    {
        Console.WriteLine($"Agenda de: {this.Proprietario}");
        Console.WriteLine("Contatos: ");
        foreach (var contato in _contatos)
        {
            Console.WriteLine($"- {contato.Nome} | {contato.Telefone}");
        }
        Console.WriteLine($"Total de contatos: {_contatos.Count}");
    }


}