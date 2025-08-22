public class SubstituindoPalavras
{
    public static void SubstituirPalavras()
    {
        Console.WriteLine("Digite uma frase: ");
        string frase = Console.ReadLine()!;

        Console.WriteLine("Qual palavra você quer substituir?");
        string palavraAntiga = Console.ReadLine()!;

        Console.WriteLine("Por qual palavra: ");
        string palavraNova = Console.ReadLine()!;

        Console.WriteLine(frase.Replace(palavraAntiga, palavraNova));
    }
}