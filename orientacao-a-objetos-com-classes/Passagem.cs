public class Passagem
{
    public string? Passageiro { get; set; }
    public string? Destino { get; set; }

    public Passagem(string passageiro, string destino)
    {
        Passageiro = passageiro;
        Destino = destino;
    }

    public static void EmitirPassagem()
    {
        Passagem passagem1 = new Passagem("Bruno Hoffmann", "Paraná");

        Console.WriteLine($"Passageiro: {passagem1.Passageiro}");
        Console.WriteLine($"Destino: {passagem1.Destino}");
    }
}