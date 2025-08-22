public class DividindoUmaString
{
    public static void DividirString()
    {
        string log = "2025-03-25,Erro,Arquivo não encontrado";

        string data = log.Split(',')[0];
        string erro = log.Split(',')[1];
        string mensagem = log.Split(',')[2];

        Console.WriteLine($"Data: {data}");
        Console.WriteLine($"erro: {erro}");
        Console.WriteLine($"mensagem: {mensagem}");
    }
}