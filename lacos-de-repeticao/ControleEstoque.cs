public class ControleEstoque
{
    public static void controlarEstoque()
    {
        int condicao;
        int quantidade = 0;
        int totalEstoque = 0;
        do
        {
            Console.WriteLine("Deseja adicionar um produto ao estoque? ");
            Console.WriteLine("1 - Sim | 0 - Não");
            condicao = int.Parse(Console.ReadLine()!);

            if (condicao == 1)
            {
                Console.WriteLine("Quantidade: ");
                quantidade = int.Parse(Console.ReadLine()!);

                totalEstoque += quantidade;

                Console.WriteLine($"Estoque atual: {totalEstoque}");
            }

        } while (condicao != 0);
    }
}