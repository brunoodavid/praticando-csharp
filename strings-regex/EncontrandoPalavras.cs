public class EncontrandoPalavras
{
    public static void EncontrarPalavras()
    {
        string palavraChave = "C#";

        Console.WriteLine("Digite um texto: ");
        string texto = Console.ReadLine()!;

        if (texto.Contains(palavraChave))
        {
            Console.WriteLine("A palavra-chave foi encontrada na pesquisa.");
        }
    }
}