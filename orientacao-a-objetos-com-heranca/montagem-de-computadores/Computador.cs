class Computador
{
    public Processador Processador;
    public PlacaMae PlacaMae;

    public Computador(Processador processador, PlacaMae placaMae)
    {
        this.Processador = processador;
        this.PlacaMae = placaMae;
    }

    public void ExibirConfiguracao()
    {
        Console.WriteLine($"Processador: {Processador.Marca} - {Processador.Modelo}");
        Console.WriteLine($"Placa Mãe: {PlacaMae.Fabricante} - {PlacaMae.Socket}");
    }
}