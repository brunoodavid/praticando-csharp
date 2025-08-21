public class BuscandoEmLista
{
    public static void BuscarNaLista()
    {
        List<string> listaDeNomes = new List<string> { "Ana", "Carlos", "Bianca", "João", "Marina" };
        bool encontrado = false;
        Console.WriteLine("Digite o nome do aluno: ");
        string aluno = Console.ReadLine()!;

        int i = 0;
        while (i < listaDeNomes.Count)
        {
            if (listaDeNomes[i] == aluno)
            {
                Console.WriteLine($"Aluno encontrado na posição: {i}");
                encontrado = true;
            }
            i++;
        }

        if (!encontrado)
        {
            Console.WriteLine("Aluno não está presente na lista");
        }
    }
}