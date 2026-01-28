class Consulta{
    public string? NomePaciente { get; set;}
    public string? NomeMedico { get; set; }
    public DateTime DataConsulta { get; set;}
    public bool foiReagendado = false;
    public Consulta(string nomePaciente, string nomeMedico, DateTime dataConsulta)
    {
        NomePaciente = nomePaciente;
        NomeMedico = nomeMedico;
        DataConsulta = dataConsulta;
    }

    public void Reagendar(DateTime novaData)
    {
        DataConsulta = novaData;
        foiReagendado = true;
    }

    public void ExibirResumo()
    {
        Console.WriteLine($"Nome paciente: {NomePaciente}");
        Console.WriteLine($"Nome médico: {NomeMedico}");
        if (foiReagendado)
        {
            Console.WriteLine($"Nova data: {DataConsulta}");
        }
        else
        {
            Console.WriteLine($"Data: {DataConsulta}");
        }
    }
}