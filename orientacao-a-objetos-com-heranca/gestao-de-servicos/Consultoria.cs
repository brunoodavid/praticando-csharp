class Consultoria : IServico
{
    public string TipoConsultoria { get; }
    public FuncionarioServico FuncionarioServico { get; }

    public Consultoria(string tipoConsultoria, FuncionarioServico funcionarioServico)
    {
        this.TipoConsultoria = tipoConsultoria;
        this.FuncionarioServico = funcionarioServico;

    }
    public void ExecutarServico()
    {
        Console.WriteLine($"Executando serviço de consultoria: {this.TipoConsultoria}");
        Console.WriteLine($"Responsável: {this.FuncionarioServico.Nome} - Departamento: {this.FuncionarioServico.Departamento}");
    }
}