public class Circulo
{
    public static void CalcularAreaEPerimetro()
    {
        decimal pi = 3.14159m;
        decimal raio = 5;
        decimal area = pi * raio * raio;
        decimal perimetro = 2 * pi * raio;

        Console.WriteLine($"Raio: {raio.ToString("F2")}");
        Console.WriteLine($"Área do círculo: {area.ToString("F2")}");
        Console.WriteLine($"Perímetro do círculo: {perimetro.ToString("F2")}");
    }
}