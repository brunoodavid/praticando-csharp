public class MiniCalculadora
{
    public static void Calcular(string operacao, int num1, int num2)
    {
        int total = 0;
        switch (operacao)
        {
            case "+":
                total = num1 + num2;
                break;
            case "-":
                total = num1 - num2;
                break;
            case "*":
                total = num1 * num2;
                break;
            case "/":
                total = num1 / num2;
                break;
            default:
                Console.WriteLine("Opção inválida");
                break;
        }
        Console.WriteLine($"Resultado: {total}");
    }
}