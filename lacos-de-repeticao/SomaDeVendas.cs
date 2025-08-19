public class SomaDeVendas
{
    public static void somarVendas()
    {
        int totalDeVendas = 0;
        int valorVenda;

        do
        {
            Console.WriteLine("Digite o valor da venda (ou 0 para encerrar): ");
            valorVenda = int.Parse(Console.ReadLine()!);
            totalDeVendas += valorVenda;
        } while (valorVenda != 0);

        Console.WriteLine($"Total de vendas do dia: R$ {totalDeVendas}");
    }
}