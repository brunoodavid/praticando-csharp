public class Impares
{
    public static void QuantosImparesTem()
    {
        List<int> numeros = new List<int> { };
        int impares = 0;

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Digite o {i}º número: ");
            int numero = int.Parse(Console.ReadLine()!);
            numeros.Add(numero);
        }

        foreach (var numero in numeros)
        {
            if (numero % 2 == 0)
            {
                continue;
            }
            else
            {
                impares++;
            }
        }

        Console.WriteLine($"Você digitou {impares} números ímpares.");
    }
}