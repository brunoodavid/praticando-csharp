public class FormatandoRelatorio
{
    public static void formatarRelatorio()
    {
        Console.WriteLine("Digite o nome do cliente: ");
        string nome = Console.ReadLine()!;

        Console.WriteLine("Digite o endereço: ");
        string endereco = Console.ReadLine()!;

        Console.WriteLine("Digite o valor do frete: ");
        decimal valorFrete = decimal.Parse(Console.ReadLine()!);

        Console.WriteLine("Digite a data de entrega: (dd/mm/yyyy)");
        string dataDigitada = Console.ReadLine()!;

        DateTime data = DateTime.Parse(dataDigitada);

        Console.WriteLine("========== RELATÓRIO DE ENTREGA ==========");
        Console.WriteLine($"Cliente:          {nome}");
        Console.WriteLine($"Endereço:         {endereco}");
        Console.WriteLine($"Valor do frete:   {valorFrete}");
        Console.WriteLine($"Data:             {data.ToString("dd/MM/yyyy")}");
        Console.WriteLine("==========================================");
        ;
    }
}