internal class HistoricoMedico
{
    public string CodigoProntuario { get; set; }

    public HistoricoMedico(string codigoProntuario)
    {
        this.CodigoProntuario = codigoProntuario;
    }

    public void ExibirCodigo()
    {
        Console.WriteLine($"Código do prontuário: {this.CodigoProntuario}");
    }
}