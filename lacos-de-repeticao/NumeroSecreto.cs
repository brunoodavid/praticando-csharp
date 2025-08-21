public class NumeroSecreto
{
    public static void NumeroSecretoASerDesconberto()
    {
        int numeroSecreto = 5;
        int palpite = 0;

        while (palpite != numeroSecreto)
        {
            Console.WriteLine("Tente adivinhar o número entre 1 e 10: ");
            palpite = int.Parse(Console.ReadLine()!);

            if (palpite < 5)
            {
                Console.WriteLine("Esta quase, o numero é um pouco maior.");
            }
            else
            {
                Console.WriteLine("Esta quase, o numero é um pouco menor.");
            }
        }
        Console.WriteLine("Parabens, você acertou!");
    }
}