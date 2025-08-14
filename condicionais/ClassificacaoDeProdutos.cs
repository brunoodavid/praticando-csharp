public class ClassificacaoDeProdutos
{
    public static void ClassificarProduto(int codigo)
    {
        if (codigo == 1)
        {
            Console.WriteLine("Perecível");
        }
        else if (codigo == 2)
        {
            Console.WriteLine("Não perecível");
        }
        else
        {
            Console.WriteLine("Código incorreto");
        }
    }
}