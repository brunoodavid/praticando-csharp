public class ConversorTemperatura
{
    public static void converterTemperatura()
    {
        int opcao = 0;
        int temperatura = 0;
        int celsius = 0;
        int fahrenheit = 0;

        while (opcao != 3)
        {
            Console.WriteLine("1 - Celsius para Fahrenheit");
            Console.WriteLine("2 - Fahrenheit para Celsius");
            Console.WriteLine("3 - Sair");
            opcao = int.Parse(Console.ReadLine()!);

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Digite a temperatura em Celsius: ");
                    temperatura = int.Parse(Console.ReadLine()!);
                    fahrenheit = (temperatura * 9 / 5) + 32;
                    Console.WriteLine($"{temperatura}ºC equivalem a {fahrenheit}ºF");
                    break;
                case 2:
                    Console.WriteLine("Digite a temperatura em Fahrenheit: ");
                    temperatura = int.Parse(Console.ReadLine()!);
                    celsius = (temperatura - 32) * 5 / 9;
                    Console.WriteLine($"{temperatura}ºF equivalem a {celsius}ºC");
                    break;
                case 3:
                    Console.WriteLine("Saindo");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
    }
}