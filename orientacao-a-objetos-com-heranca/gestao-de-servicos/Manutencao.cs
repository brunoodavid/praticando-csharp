class Manutencao : IServico
{
    public string TipoManutencao { get;}
    public FuncionarioServico FuncionarioServico { get;}

    public Manutencao(string tipoManutencao, FuncionarioServico funcionarioServico)
    {
        TipoManutencao = tipoManutencao;
        FuncionarioServico = funcionarioServico;

    }
    public void ExecutarServico()
    {
        Console.WriteLine($"Executando serviço de manutenção: {this.TipoManutencao}");
        Console.WriteLine($"Responsável: {this.FuncionarioServico.Nome} - Departamento: {this.FuncionarioServico.Departamento}");
    }
}