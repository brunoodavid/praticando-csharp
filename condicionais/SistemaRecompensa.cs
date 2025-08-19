public class SistemaRecompensa
{
    public static void retornarRecompensa()
    {
        Console.WriteLine("Digite o código de recompensa: (DOBRAR, CURAR, OURO, ESPECIAL)");
        string codigo = Console.ReadLine()!;

        switch (codigo)
        {
            case "DOBRAR":
                Console.WriteLine("Ganhar 2x EXP por 1 hora desbloqueado.");
                break;
            case "CURAR":
                Console.WriteLine("Poção de cura desbloqueada.");
                break;
            case "OURO":
                Console.WriteLine("1000 moedas de ouro desbloqueada.");
                break;
            case "ESPECIAL":
                Console.WriteLine("Item lendário desbloqueado.");
                break;
            default:
                Console.WriteLine("Opção inválida");
                break;
        }
    }
}