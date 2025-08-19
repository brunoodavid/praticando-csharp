public class Saudacao
{
    public static void Saudar(int codigo, string nome)
    {
        switch (codigo)
        {
            case 1:
                Console.WriteLine($"Bom dia, {nome}.");
                break;
            case 2:
                Console.WriteLine($"Bom tarde, {nome}.");
                break;
            case 3:
                Console.WriteLine($"Bom noite, {nome}.");
                break;
            default:
                Console.WriteLine("Opção inválida");
                break;
        }
    }
}