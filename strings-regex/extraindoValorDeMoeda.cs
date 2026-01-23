using System.Text.RegularExpressions;

public class ExtraindoValorDeMoeda
{
    public static void extrairValorDeMoeda()
    {
        Console.WriteLine("Digite o texto do recibo: ");
        string texto = Console.ReadLine()!;

        string regex = @"R\$ \d+,\d{2}";

        string valor = Regex.Match(texto, regex).Value;

        Console.WriteLine($"Valor encontrado: {valor}");
    }
}