public class ContandoCaracteres
{
    public static void contarCaracteres()
    {
        Console.WriteLine("Digite uma frase: ");
        string frase = Console.ReadLine()!;

        Console.WriteLine($"A frase contém {frase.Length} caracteres.");
    }
}